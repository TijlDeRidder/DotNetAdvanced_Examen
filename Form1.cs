using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Metadata;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
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
            getData();
            foreach (var item in Station.LijstStation)
            {
                cb_metrostation.Items.Add(item.ToString());
            }
        }

        private void cb_metrostation_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_liften.Items.Clear();
            string name = cb_metrostation.Text;
            Station huidig = Station.findStationByName(name);
            List<Lift> huidigeLiften = new List<Lift>();
            huidigeLiften = Lift.FindLiftsByStationId(huidig);
            if(huidigeLiften.Count != 0)
            {
                foreach (Lift lift in huidigeLiften)
                {
                    lb_liften.Items.Add(lift.ToString());
                }
            }
            else
            {
                lb_liften.Items.Add("Dit station is niet ");
                lb_liften.Items.Add("toegankelijk");
                lb_status.Visible = false;
                lb_liftnaam.Visible = false;
                tb_liftnaam.Visible=false;
                tb_status.Visible = false;
            }
            
        }
        private void lb_liften_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_status.Visible = true;
            lb_liftnaam.Visible = true;
            Lift huidig = Lift.findLiftByName(lb_liften.Text);
            tb_liftnaam.Text = huidig.ToString();
            tb_liftnaam.Visible = true;
            if(huidig.GetIsWorking() == 1)
            {
                tb_status.Text = "Werkt";
                b_defect.Visible = true;


            }
            else if(huidig.GetIsWorking() == 0)
            {
                tb_status.Text = "Werkt Niet";
                b_defect.Visible = false;
            }
            tb_status.Visible = true;
        }

        private void b_defect_Click(object sender, EventArgs e)
        {
            Lift huidig = Lift.findLiftByName(lb_liften.Text);
            Form defect = new LiftDefectMDI(huidig);
            defect.Text = huidig.ToString();
            defect.ShowDialog();
        }
        private void getData()
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
                        Lift.LijstSLiften.Add(new Lift(reader2.GetInt32(0), reader2.GetString(1), reader2.GetInt32(2), reader2.GetByte(3)));
                    }
                }
            }
        }
    }
}