using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Metadata;
using System;
using System.Data.SqlClient;
using System.Data;

namespace DotNetAdvanced_Examen
{
    public partial class LiftMeUp : Form
    {
        public LiftMeUp()
        {
            InitializeComponent();

        }
        private void LiftMeUp_Load(object sender, EventArgs e)
        {
            string dbConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\tijl-\\OneDrive\\Documenten\\Stations.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(dbConnection);
            SqlCommand command = new SqlCommand("SELECT Id, Naam, Is_Accecible, Has_Elevator FROM Stations", connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Station.LijstStation.Add(new Station(reader.GetInt32(0), reader.GetString(1), reader.GetByte(2), reader.GetByte(3)));
                }
                connection.Close();
                SqlCommand command2 = new SqlCommand("SELECT Id, Naam, Station_id, Is_Working FROM Liften", connection);
                connection.Open();
                using (SqlDataReader reader2 = command2.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        Lift.LijstLift.Add(new Lift(reader2.GetInt32(0), reader2.GetString(1), reader2.GetInt32(2), reader2.GetByte(3)));
                        string test = "";
                        foreach (var item in Lift.LijstLift)
                        {
                            test += item.ToString();
                        }
                        MessageBox.Show(test);
                    }
                }
                foreach (var item in Station.LijstStation)
                {
                    cb_metrostation.Items.Add(item.ToString());
                }
                
            }
        }

        private void cb_metrostation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cb_metrostation.Text;
            Station huidig = findStationByName(name);
                        
        }

        public Station findStationByName(string naam)
        {
            Station station = null;
            foreach (var item in Station.LijstStation)
            {
                if (item.Equals(naam))
                {
                    station = item;
                }
            }
            return station;
        }




    }
}