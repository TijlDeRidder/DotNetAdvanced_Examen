using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvanced_Examen
{
    public class Melding
    {
        public static List<Melding> Meldingen = new List<Melding>();
        public static int MeldingCount = 0;
        public Lift lift;
        private int id;
        private string uitleg;
        private DateTime date;

        public Melding(Lift lift, string uitleg, DateTime date)
        {
            this.lift = lift;
            this.id = Meldingen.Count + 1;
            this.uitleg = uitleg;
            this.date = date;
        }
        public Melding(int id, int liftId, int stationId, DateTime date, String uitleg)
        {
            this.id = Meldingen.Count + 1;
            this.lift = Lift.findLiftById(liftId);
            this.uitleg = uitleg;
            this.date = date;
        }

        public override string? ToString()
        {
            return "[" + lift.ToString() + "]: " + date.ToString() + " " + uitleg;
        }
        public DateTime GetDateTime()
        {
            return date;
        }
        public Lift GetLift()
        {
            return lift;
        }
        public string GetUitleg()
        {
            return uitleg;
        }

        public void addMeldingToDB()
        {
            string dbConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\tijl-\\OneDrive\\Documenten\\Stations.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(dbConnection);
            SqlCommand command = new SqlCommand("INSERT INTO MELDINGEN(Id,LiftId,Station_Id,Date,Uitleg) VALUES(@Id,@LiftId,@StationId,@Date,@Uitleg)", connection);
            connection.Open();
            command.Parameters.AddWithValue("@Id", this.id);
            command.Parameters.AddWithValue("@LiftId", this.lift.GetId());
            command.Parameters.AddWithValue("@StationId", this.lift.StationId);
            command.Parameters.AddWithValue("@Date", this.date);
            command.Parameters.AddWithValue("@Uitleg", this.uitleg);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void updateMeldingDB()
        {
            string dbConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\tijl-\\OneDrive\\Documenten\\Stations.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(dbConnection);
            SqlCommand command = new SqlCommand("DELETE FROM MELDINGEN WHERE ID=(@Id)", connection);
            connection.Open();
            using (command)
            {
                command.Parameters.AddWithValue("@Id", this.id);
                command.ExecuteNonQuery();

            }
        }
    }
}
