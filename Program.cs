using Rayco_Planner.Classes;
using Rayco_Planner.Forms;
using RayCo_PMS_PC;

namespace Rayco_Planner
{
    internal static class Program
    {
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
            DeelTaak VacaturesAfstruinen = new DeelTaak(2, "Vacatures afstruinen", "Moedeloos worden van HR en recruiters", 1, 5, "developer", null, 1);
            DeelTaak AfgewezenWorden = new DeelTaak(3, "Afgewezen worden", "Sorry, een andere kandidaat had een beter profiel", 1, 1, "developer", new List<DeelTaak> { StressErvaren, VacaturesAfstruinen }, 1);

            //deeltaken aan een projectsoort toevoegen
            OverspannenRaken.VoegDeelTaakToe(StressErvaren);
            OverspannenRaken.VoegDeelTaakToe(VacaturesAfstruinen);
            OverspannenRaken.VoegDeelTaakToe(AfgewezenWorden);

            projectSoorten.Add(OverspannenRaken);

            //project maken van projectsoort
            Project carriere = new Project("Carri�re stress", "Bart", OverspannenRaken);

            //projectlid 28 jaar na dato nog eens maken
            ProjectLid Bart = projectLeden.FirstOrDefault(projectlid => projectlid.VoorNaam == "Bart");

            //projectlid toevoegen aan het project
            carriere.TaakToewijzen(0, Bart);
            carriere.TaakToewijzen(1, Bart);
            carriere.TaakToewijzen(2, Bart);
            
            //applicatie starten
            ApplicationConfiguration.Initialize();
            Application.Run(new InlogScherm(dBConnectie, projectSoorten, projectLeden));
        }
    }
}