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
    public partial class ProjectToevoegen : Form
    {
        List<ProjectLid> projectleden = new List<ProjectLid>();
        List<ProjectSoort> projectsoort = new List<ProjectSoort>();
        
        public ProjectToevoegen(List<ProjectLid> projectleden, List<ProjectSoort> projectsoort)
        {
            InitializeComponent();
            this.projectleden = projectleden;
            this.projectsoort = projectsoort;
        }

        private void ProjectToevoegen_Load(object sender, EventArgs e)
        {
            foreach (ProjectLid projectlid in projectleden)
            {
                ProjectLedenBox.Items.Add(projectlid.VoorNaam + " " + projectlid.AchterNaam);
            }

            foreach (ProjectSoort projectSoort in projectsoort)
            {
                SoortenBox.Items.Add(projectSoort.Naam);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectSoort gekozenProjectSoort = null;
            
            foreach (ProjectSoort projectSoort in projectsoort)
            {
                if (projectSoort.Naam == SoortenBox.Text)
                {
                    gekozenProjectSoort = projectSoort;
                }
            }

            Project project = new Project(NaamBox.Text, OpdrachtgeverBox.Text, gekozenProjectSoort);
            this.Close();
        }
    }
}
