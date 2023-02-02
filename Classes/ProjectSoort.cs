using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        public bool VoegDeelTaakToe(DeelTaak nieuweDeelTaak)
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

        public int zoekMinimaleDoorlooptijd(DeelTaak taak)
        {
            int minimaleDoorloopTijd = taak.MinimaleUren;
            if (taak.VoorgaandeTaak == null) return minimaleDoorloopTijd;
            if (taak.VoorgaandeTaak.Count == 0) return minimaleDoorloopTijd;
            else if (taak.VoorgaandeTaak.Count == 1)
            {
                foreach (DeelTaak voorgaandeTaak in taak.VoorgaandeTaak)
                {
                    minimaleDoorloopTijd += zoekMinimaleDoorlooptijd(voorgaandeTaak);
                }
                return minimaleDoorloopTijd;
            }
            else
            {
                int langsteKeten = 0;
                int ketenDuur = 0;
                foreach (DeelTaak voorgaandetaak in taak.VoorgaandeTaak)
                {
                    ketenDuur = zoekMinimaleDoorlooptijd(voorgaandetaak);
                    if (ketenDuur >= langsteKeten)
                    {
                        langsteKeten = ketenDuur;
                    }
                }
                return langsteKeten + minimaleDoorloopTijd;
            }
        }

        public int berekenenMinimaleDoorlooptijd()
        {
            int minimaledoorlooptijd = 0;

            foreach (DeelTaak taak in ProjectDeelTaken)
            {
                if (zoekMinimaleDoorlooptijd(taak) >= minimaledoorlooptijd)
                {
                    minimaledoorlooptijd = zoekMinimaleDoorlooptijd(taak);
                }
            }
            return minimaledoorlooptijd;
        }

        private int zoekMaximaleDoorlooptijd(DeelTaak taak)
        {
            int maximaledoorlooptijd = taak.MaximaleUren;
            if (taak.VoorgaandeTaak == null) return maximaledoorlooptijd;
            if (taak.VoorgaandeTaak.Count == 0) return maximaledoorlooptijd;
            else if (taak.VoorgaandeTaak.Count == 1)
            {
                foreach (DeelTaak voorgaandetaak in taak.VoorgaandeTaak)
                {
                    maximaledoorlooptijd += zoekMaximaleDoorlooptijd(voorgaandetaak);
                }
                return maximaledoorlooptijd;
            }
            else
            {
                int langsteKeten = 0;
                int ketenDuur = 0;
                foreach (DeelTaak voorgaandetaak in taak.VoorgaandeTaak)
                {
                    ketenDuur = zoekMaximaleDoorlooptijd(voorgaandetaak);
                    if (ketenDuur >= langsteKeten)
                    {
                        langsteKeten = ketenDuur;
                    }
                }
                return langsteKeten + maximaledoorlooptijd;
            }
        }

        public int berekenMaximaleDoorlooptijd()
        {
            int maximaledoorlooptijd = 0;

            foreach (DeelTaak taak in ProjectDeelTaken)
            {
                if (zoekMaximaleDoorlooptijd(taak) > maximaledoorlooptijd)
                {
                    maximaledoorlooptijd = zoekMaximaleDoorlooptijd(taak);
                }
            }
            return maximaledoorlooptijd;
        }
    }
}