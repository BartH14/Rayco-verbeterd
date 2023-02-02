using Rayco_Planner.Classes;
using RayCo_PMS_PC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rayco_Planner.Forms
{
    public partial class DashboardAdmin : Form
    {
        List<ProjectLid> projectleden = new List<ProjectLid>();
        List<ProjectSoort> projectsoorten = new List<ProjectSoort>();
        List<Project> projecten = new List<Project>();
        private ProjectLid gebruiker;
        private Project gekozenProject;

        public DashboardAdmin(List<ProjectLid> projectleden, List<ProjectSoort> projectsoorten)
        {
            InitializeComponent();
            this.gebruiker = projectleden[2];
            this.projectleden = projectleden;
            this.projectsoorten = projectsoorten;

            foreach (Project project in gebruiker.ToegewezenProjecten)
            {
                ProjectenLijst.Items.Add(project.Naam);
            }

            gekozenProject = gebruiker.ToegewezenProjecten[0];
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
            foreach (Project project in gebruiker.ToegewezenProjecten)
            {
                if (project.Naam == ProjectenLijst.SelectedItem.ToString())
                {
                    gekozenProject = project;
                }
            }
        }

        private void DoorlooptijdKnop_Click(object sender, EventArgs e)
        {
            int doorlooptijd = gekozenProject.projectSoort.berekenenMinimaleDoorlooptijd();
            richTextBox1.Text = ($"De doorlooptijd is {doorlooptijd}.");
        }

        private void KritiekePadKnop_Click(object sender, EventArgs e)
        {
            int kritiekepad = gekozenProject.projectSoort.berekenMaximaleDoorlooptijd();
            richTextBox1.Text = ($"De maximale doorlooptijd is {kritiekepad}.");
        }

        private void TakenKnop_Click(object sender, EventArgs e)
        {
            List<Taak> mijntaken = gebruiker.ToegewezenTaken;

            StringBuilder sb = new StringBuilder($"De volgende taken zijn aan {gebruiker.Naam} toegewezen:");
            foreach (Taak taak in mijntaken)
            {
                sb.Append($"\n • {taak.deelTaak.TaakNaam} : {taak.deelTaak.Beschrijving}");
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
