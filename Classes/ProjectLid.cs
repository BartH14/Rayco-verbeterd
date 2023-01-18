using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayco_Planner.Classes
{
    public class ProjectLid
    {
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public string Rol { get; private set; }
        public bool AdminRechten { get; private set; } = false;
        public List<Project> ToegewezenProjecten { get; set; } = new List<Project> { };
        public List<Taak> ToegewezenTaken { get; set; } = new List<Taak> { };

        public ProjectLid(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }
    }
}