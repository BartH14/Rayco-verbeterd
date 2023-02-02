using Rayco_Planner.Classes;
using Rayco_Planner.Forms;
using RayCo_PMS_PC;

namespace Rayco_Planner
{
    internal static class Program
    {
        public static DBConnectie DBConnectie
        {
            get => default;
            set
            {
            }
        }

        internal static HRKoppeling HRKoppeling
        {
            get => default;
            set
            {
            }
        }

        public static Project Project
        {
            get => default;
            set
            {
            }
        }

        public static ProjectSoort ProjectSoort
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBConnectie dBConnectie = DBConnectie.GetInstantie();
            HRKoppeling hRKoppeling = HRKoppeling.GetInstantie();
            
            List<ProjectLid> projectLeden = hRKoppeling.HaalProjectLedenOp();
            List<ProjectSoort> projectSoorten = new List<ProjectSoort>();

            // projectsoorten toevoegen
            ProjectSoort OverspannenRaken = new ProjectSoort("Overspannen raken");
            ProjectSoort CodeRefractoren = new ProjectSoort("Code refractoren");
            ProjectSoort MiBoPlannen = new ProjectSoort("Middag borrel plannen");

            //deeltaken toevoegen
            DeelTaak StressErvaren = new DeelTaak(1, "Stress ervaren", "Bossfight music zonder bossfight", 1, 20, "developer", null, 1);
            DeelTaak VacaturesAfstruinen = new DeelTaak(2, "Vacatures afstruinen", "Moedeloos worden van HR en recruiters", 1, 5, "developer", new List<DeelTaak> { StressErvaren }, 1);
            DeelTaak AfgewezenWorden = new DeelTaak(3, "Afgewezen worden", "Sorry, een andere kandidaat had een beter profiel", 1, 1, "developer", new List<DeelTaak> { VacaturesAfstruinen }, 1);

            DeelTaak SpeciaalBierHalen = new DeelTaak(1, "Speciaalbier halen", "Een gecureerde lijst van untappd afplukken", 1, 5, "developer", null, 1);
            DeelTaak BitterBallenFrituren = new DeelTaak(2, "Bitterballen frituren", "Een droogje voor bij het natje", 1, 2, "developer", new List<DeelTaak> { SpeciaalBierHalen }, 1);


            //deeltaken aan een projectsoort toevoegen
            OverspannenRaken.VoegDeelTaakToe(StressErvaren);
            OverspannenRaken.VoegDeelTaakToe(VacaturesAfstruinen);
            OverspannenRaken.VoegDeelTaakToe(AfgewezenWorden);

            MiBoPlannen.VoegDeelTaakToe(SpeciaalBierHalen);
            MiBoPlannen.VoegDeelTaakToe(BitterBallenFrituren);

            projectSoorten.Add(OverspannenRaken);

            //project maken van projectsoort
            Project carriere = new Project("Carrière stress", "Bart", OverspannenRaken);
            Project blokafronden = new Project("Blok afrond borrel", "Bart", MiBoPlannen);


            //projectlid 28 jaar na dato nog eens maken
            ProjectLid Bart = projectLeden.FirstOrDefault(projectlid => projectlid.Naam == "Bart Haagmans");
            Bart.Rol = "developer";

            //Projectlid toewijzen aan projecten
            carriere.ProjectLidToevoegen(Bart);
            blokafronden.ProjectLidToevoegen(Bart);

            //projectlid de deeltaken toewijzen
            carriere.TaakToewijzen(0, Bart);
            carriere.TaakToewijzen(1, Bart);
            carriere.TaakToewijzen(2, Bart);

            blokafronden.TaakToewijzen(0, Bart);
            blokafronden.TaakToewijzen(1, Bart);
            
            //applicatie starten
            ApplicationConfiguration.Initialize();
            Application.Run(new InlogScherm(dBConnectie, projectSoorten, projectLeden));
        }
    }
}