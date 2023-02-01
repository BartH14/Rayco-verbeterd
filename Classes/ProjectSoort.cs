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
        public bool controleerKeten()
        {
            foreach (DeelTaak taak in ProjectDeelTaken)
            {
                if (taak.VoorgaandeTaak.Count == 0)
                {
                    continue;
                }

                foreach (DeelTaak voorgaandeTaak in taak.VoorgaandeTaak)
                {
                    foreach (DeelTaak overVoorgaandeTaak in voorgaandeTaak.VoorgaandeTaak)
                    {
                        if (overVoorgaandeTaak.Id == taak.Id) return true;
                    }
                }
            }
            return false;
        }
   }
}
