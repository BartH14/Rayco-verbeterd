using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCo_PMS_PC
{
    public sealed class DBConnectie
    {
        private static DBConnectie _instantie;
        readonly public static string DBnaam = "PMS";
        public SqlConnection verbinding = new SqlConnection($"Server=(local); Database={DBnaam}; Integrated Security=true");

        // private constructor maken om externe instantiëring te voorkomen
        private DBConnectie() { }

        //singleton pattern
        public static DBConnectie GetInstantie()
        {
            if (_instantie == null)
                _instantie = new DBConnectie();
            return _instantie;
        }

        // Functie maken om de verbinding te openen
        public void openVerbinding()
        {
            if (verbinding.State == System.Data.ConnectionState.Closed)
            {
                verbinding.Open();
            }
        }

        // Functie maken om de verbinding te sluiten
        public void sluitVerbinding()
        {
            if (verbinding.State == System.Data.ConnectionState.Open)
            {
                verbinding.Close();
            }
        }

        //deze functie kijkt of de gegevens die de gebruiker heeft ingevoerd voorkomen in de database, returnt true/false
        public bool LogGebruikerIn(string gebruikersnaam, string wachtwoord)
        {
            openVerbinding();
            string query = $"SELECT * FROM Projectleden WHERE Gebruikersnaam = '{gebruikersnaam}' AND Wachtwoord = '{wachtwoord}'";
            SqlCommand command = new SqlCommand(query, verbinding);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
            
        }
        //deze functie kijkt of de gebruiker adminrechten heeft of niet
        public bool GebruikersRol( string gebruikersnaam)
        {
            openVerbinding();
            string query = $"SELECT * FROM Projectleden WHERE Gebruikersnaam = '{gebruikersnaam}' AND adminrechten = '1'";
            SqlCommand command = new SqlCommand(query, verbinding);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }
    }
}