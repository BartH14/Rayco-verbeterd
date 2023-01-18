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
    public partial class InlogScherm : Form
    {
        public DBConnectie dBConnectie;
        List<ProjectLid> projectleden = new List<ProjectLid>();
        List<ProjectSoort> projectsoorten = new List<ProjectSoort>();
        public InlogScherm(DBConnectie dBConnectie, List<ProjectSoort> projectsoorten, List<ProjectLid> projectleden)
        {
            InitializeComponent();
            this.dBConnectie = dBConnectie;
            this.projectsoorten = projectsoorten;
            this.projectleden = projectleden;
        }

        private void LoginKnop_Click(object sender, EventArgs e)
        {
            dBConnectie.openVerbinding();

            if (dBConnectie.LogGebruikerIn(GebruikersnaamVeld.Text, WachtwoordVeld.Text))
            {
                if(dBConnectie.GebruikersRol(GebruikersnaamVeld.Text))
                {
                    new DashboardAdmin(projectleden, projectsoorten).Show();
                    this.Close();
                }
                else
                {
                    new DashboardGebruiker(projectleden, projectsoorten).Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Gebruikersnaam of wachtwoord is onjuist!");
            }
        }

        private void InlogScherm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DBConnectie.DBserver = textBox1.Text;
        }
    }
}
