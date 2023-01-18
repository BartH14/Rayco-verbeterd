using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayco_Planner.Classes
{
    internal class ProjectLid
    {
        public int Id { get; private set; }
        public string VoorNaam { get; private set; }
        public string AchterNaam { get; private set; }
        public string Rol { get; private set; }
        public bool AdminRechten { get; private set; } = false;
        public List<Project> ToegewezenProjecten { get; set; } = new List<Project> { };
        public List<Taak> ToegewezenTaken { get; set; } = new List<Taak> { };

        public ProjectLid(int id, string voornaam, string achternaam, string rol, string adminrechten)
        {
            Id = id;
            VoorNaam = voornaam;
            AchterNaam = achternaam;
            Rol = rol;
        }
    }
}
