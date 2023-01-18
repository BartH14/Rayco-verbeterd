using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayco_Planner.Classes
{
    internal class Project
    {
        public string Naam { get; private set; }
        public string Opdrachtgever { get; private set; }
        public ProjectSoort projectSoort { get; private set; }
        public List<Taak> projectTaken { get; private set; } = new List<Taak> { };
        public List<ProjectLid> uitvoerendeProjectLeden { get; private set; } = new List<ProjectLid> { };

        public Project(string naam, string opdrachtgever, ProjectSoort projectsoort)
        {
            Naam = naam;
            Opdrachtgever = opdrachtgever;
            projectSoort = projectsoort;

            int i = 0;
            foreach (DeelTaak deelTaak in projectSoort.ProjectDeelTaken)
            {
                projectTaken.Add(new Taak(i, deelTaak));
                i++;
            }
        }

        public bool TaakToewijzen(int taakId, ProjectLid toegewezenProjectLid)
        {
            foreach (Taak taak in projectTaken)
            {
                if (taak.Id == taakId)
                {
                    if (uitvoerendeProjectLeden.Contains(toegewezenProjectLid))
                    {
                        if (taak.WijsToeAanProjectLid(toegewezenProjectLid))
                        {
                            toegewezenProjectLid.ToegewezenTaken.Add(taak);
                            return true;
                        }
                        else return false;
                    }
                    else return false;
                }
            }
            return false;
        }

        public bool ProjectLidToevoegen(ProjectLid projectlid)
        {
            if (uitvoerendeProjectLeden.Contains(projectlid)) return false;
            else
            {
                uitvoerendeProjectLeden.Add(projectlid);
                projectlid.ToegewezenProjecten.Add(this);
                return true;
            }
        }
    }
}
