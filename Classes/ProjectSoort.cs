using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayco_Planner.Classes
{
    public class ProjectSoort
    {
        public string Naam { get; }
        public List<DeelTaak> ProjectDeelTaken { get; set; } = new List<DeelTaak>();

        public DeelTaak DeelTaak
        {
            get => default;
            set
            {
            }
        }

        public Taak Taak
        {
            get => default;
            set
            {
            }
        }

        public ProjectLid ProjectLid
        {
            get => default;
            set
            {
            }
        }

        public ProjectSoort(string naam)
        {
            Naam = naam;
        }

        public bool VoegDeelTaakToe (DeelTaak nieuweDeelTaak)
        {
            foreach (DeelTaak deeltaak in ProjectDeelTaken)
            {
                if (deeltaak.Id == nieuweDeelTaak.Id)
                {
                    return false;
                }
            }
            ProjectDeelTaken.Add(nieuweDeelTaak);
            return true;
        }

        public bool VerwijderDeelTaak(DeelTaak deeltaak)
        {
            if (ProjectDeelTaken.Contains(deeltaak))
            {
                ProjectDeelTaken.Remove(deeltaak);
                return true;
            }
            else return false;
        }
   }
}
