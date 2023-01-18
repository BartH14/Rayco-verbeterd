using Rayco_Planner.Classes;
using RayCo_PMS_PC;
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
    public partial class DashboardAdmin : Form
    {
        List<ProjectLid> projectleden = new List<ProjectLid>();
        List<ProjectSoort> projectsoorten = new List<ProjectSoort>();

        public DashboardAdmin(List<ProjectLid> projectleden, List<ProjectSoort> projectsoorten)
        {
            InitializeComponent();
            this.projectleden = projectleden;
            this.projectsoorten = projectsoorten;
        }

        private void projectToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProjectToevoegen(projectleden, projectsoorten).Show();
        }

        private void HoofdMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
