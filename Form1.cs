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
            update_lists();
            fill_tab_meldingen(Melding.MeldingCount);
        }

        private void cb_metrostation_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_status.Visible = false;
            lb_liftnaam.Visible = false;
            tb_liftnaam.Visible = false;
            tb_status.Visible = false;
            b_defect.Visible = false;
            lb_liften.Items.Clear();
            string name = cb_metrostation.Text;
            Station huidig = Station.findStationByName(name);
            List<Lift> huidigeLiften = new List<Lift>();
            huidigeLiften = Lift.FindLiftsByStationId(huidig);
            if (huidigeLiften.Count != 0)
            {
                huidigeLiften.ForEach(lift => lb_liften.Items.Add(lift.ToString()));
            }
            else if(huidig.GetIsAccecible() == 0)
            {
                lb_liften.Items.Add("Dit station is niet ");
                lb_liften.Items.Add("toegankelijk");
                lb_status.Visible = false;
                lb_liftnaam.Visible = false;
                tb_liftnaam.Visible = false;
                tb_status.Visible = false;
                b_defect.Visible = false;
            }
            else if(huidig.GetIsAccecible() == 1 && huidig.GetHasElevator() == 0)
            {
                lb_liften.Items.Add("Dit station is");
                lb_liften.Items.Add("toegankelijk zonder");
                lb_liften.Items.Add("lift");
                lb_status.Visible = false;
                lb_liftnaam.Visible = false;
                tb_liftnaam.Visible = false;
                tb_status.Visible = false;
                b_defect.Visible = false;
            }

        }
        private void fill_tab_meldingen(int index)
        {
            if(Melding.Meldingen.Count > 0)
            {
                Melding huidig = Melding.Meldingen[index];
                tb_showDatum.Text = huidig.GetDateTime().ToString();
                tb_showStation.Text = Station.findStationById(huidig.lift.StationId).ToString();
                tb_showLift.Text = huidig.lift.ToString();
                rtb_showUitleg.Text = huidig.GetUitleg();
            }
        }
        private void lb_liften_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lift huidig = Lift.findLiftByName(lb_liften.Text);
            if (huidig != null)
            {
                            lb_status.Visible = true;
            lb_liftnaam.Visible = true;
            tb_liftnaam.Text = huidig.ToString();
            tb_liftnaam.Visible = true;
            if (huidig.GetIsWorking() == 1)
            {
                tb_status.Text = "Werkt";
                b_defect.Visible = true;


            }
            else if (huidig.GetIsWorking() == 0)
            {
                tb_status.Text = "Werkt Niet";
                b_defect.Visible = false;
            }
            tb_status.Visible = true;
            }
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
         string info = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\", "Stations.mdf"));
         string dbConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                        $"AttachDbFilename={info};" +
                                        "Integrated Security=True;" +
                                        "Connect Timeout=30";
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
            }
            SqlCommand command2 = new SqlCommand("SELECT Id, Naam, Station_id, Is_Working FROM Liften", connection);
            connection.Open();
            using (SqlDataReader reader2 = command2.ExecuteReader())
            {
                while (reader2.Read())
                {
                    Lift.LijstSLiften.Add(new Lift(reader2.GetInt32(0), reader2.GetString(1), reader2.GetInt32(2), reader2.GetByte(3)));
                }
                connection.Close();
            }
            SqlCommand command3 = new SqlCommand("SELECT Id, liftId, Station_id, Date, Uitleg FROM Meldingen", connection);
            connection.Open();
            using (SqlDataReader reader3 = command3.ExecuteReader())
            {
                while (reader3.Read())
                {
                    Melding.Meldingen.Add(new Melding(reader3.GetInt32(0), reader3.GetInt32(1), reader3.GetInt32(2), reader3.GetDateTime(3), reader3.GetString(4)));
                }
                connection.Close();
            }
        }

        private void b_volgende_Click(object sender, EventArgs e)
        {
            if(Melding.MeldingCount + 1 < Melding.Meldingen.Count)
            {
                Melding.MeldingCount++;
            }
            else
            {
                Melding.MeldingCount = 0;
            }
            
            fill_tab_meldingen(Melding.MeldingCount);
        }

        private void b_vorige_Click(object sender, EventArgs e)
        {
            if (Melding.MeldingCount != 0)
            {
                Melding.MeldingCount--;
            }
            else
            {
            
                Melding.MeldingCount = Melding.Meldingen.Count;
                Melding.MeldingCount--;
            }

            fill_tab_meldingen(Melding.MeldingCount);
        }

        private void b_fixed_Click(object sender, EventArgs e)
        {
        if(Melding.Meldingen.Count != 0)
            {
                Melding huidig = Melding.Meldingen[Melding.MeldingCount];
                huidig.lift.SetIsWorking(1);
                huidig.lift.updateLiftDB();
                huidig.updateMeldingDB();
                Melding.Meldingen.Remove(huidig);
                Melding.MeldingCount = 0;
                fill_tab_meldingen(Melding.MeldingCount);
            }
            else
            {
                tb_showDatum.Clear();
                tb_showStation.Clear();
                tb_showLift.Clear();
                rtb_showUitleg.Clear();
            }

        }

        private void b_station_toevoegen_Click(object sender, EventArgs e)
        {
            byte hasElevator;
            byte isAccesible;
            if (rb_isAccesible_ja.Checked)
            {
                isAccesible = 1;
            }
            else
            {
                isAccesible = 0;
            }
            if (rb_hasElevator_ja.Checked)
            {
                hasElevator = 1;
            }
            else
            {
                hasElevator = 0;
            }
            Station nieuwStation = new Station(tb_station_toevoegen_naam.Text, isAccesible,hasElevator);
            Station.LijstStation.Add(nieuwStation);
            nieuwStation.addStationToDB();
            update_lists();
            tb_station_toevoegen_naam.Clear();
            rb_isAccesible_ja.Checked = false;
            rb_isAccesible_nee.Checked = false;
            rb_hasElevator_ja.Checked = false;
            rb_hasElevator_nee.Checked = false;
        }

        private void b_lift_toevoegen_Click(object sender, EventArgs e)
        {
            byte isWorking;
            if (rb_isWorking_ja.Checked)
            {
                isWorking = 1;
            }
            else
            {
                isWorking = 0;
            }
            int stationId = Station.findStationByName(cb_metrostation_toevoegen.Text).GetStationId();
            Lift nieuweLift = new Lift(tb_lift_toevoegen_naam.Text, stationId, isWorking);
            Lift.LijstSLiften.Add(nieuweLift);
            nieuweLift.addLiftToDB();
            tb_lift_toevoegen_naam.Clear();
            rb_isWorking_ja.Checked = false;
            rb_isWorking_nee.Checked = false;
        }

        //Lambda expressie
        private void update_lists()
        {
            Station.LijstStation.ForEach(station => cb_metrostation.Items.Add(station.ToString()));
            Station.LijstStation.ForEach(station => cb_metrostation_toevoegen.Items.Add(station.ToString()));
        }
    }
}