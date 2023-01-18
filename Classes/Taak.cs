using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayco_Planner.Classes
{
    internal class Taak
    {
        public int Id { get; private set; }
        public DeelTaak deelTaak { get; private set; }
        public ProjectLid? toegewezenLid { get; private set; }

        public Taak (int id, DeelTaak deeltaak)
        {
            Id = id;
            deelTaak = deeltaak;
        }

        public bool WijsToeAanProjectLid(ProjectLid projectlid)
        {
            string BenodigdeRol = deelTaak.Rol;
            string LidRol = projectlid.Rol;

            if (BenodigdeRol == LidRol)
            {
                toegewezenLid = projectlid;
                return true;
            }
            else return false;
        }
    }
}
