using Rayco_Planner.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rayco_Planner.Forms
{
    public partial class DashboardGebruiker : Form
    {
        List<ProjectLid> projectleden = new List<ProjectLid>();
        List<ProjectSoort> projectsoorten = new List<ProjectSoort>();
        public DashboardGebruiker(List<ProjectLid> projectleden, List<ProjectSoort> projectsoorten)
        {
            InitializeComponent();
            this.projectleden = projectleden;
            this.projectsoorten = projectsoorten;
        }

        private void DashboardGebruiker_Load(object sender, EventArgs e)
        {

        }
    }
}
