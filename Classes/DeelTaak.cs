using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayco_Planner.Classes
{
    public class DeelTaak
    {
        public int Id { get; set; }
        public string TaakNaam { get; set; }
        public string Beschrijving { get; set; }
        public int MinimaleUren { get; set; }
        public int MaximaleUren { get; set; }
        public string Rol { get; set; }
        public List<DeelTaak> VoorgaandeTaak { get; set; } = null;
        public int TaakStatus { set; get; } = 0;

        public DeelTaak(int id, string taaknaam, string beschrijving, int minimaleuren, int maximaleuren, string rol, List<DeelTaak>? voorgaandetaak, int taakstatus)
        {
            Id = id;
            TaakNaam = taaknaam;
            Beschrijving = beschrijving;
            MinimaleUren = minimaleuren;
            MaximaleUren = maximaleuren;
            Rol = rol;
            VoorgaandeTaak = voorgaandetaak;
            TaakStatus = taakstatus;
        }
    }
}