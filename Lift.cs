using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvanced_Examen
{
    public class Lift
    {
        public static List<Lift> LijstSLiften = new List<Lift>();
        private int Id;
        private string Name { get; set; }
        public int StationId { get; set; }
        private byte Is_Working { get; set; }

        public Lift(int id, string name, int stationId, byte is_Working)
        {
            Id = id;
            Name = name;
            StationId = stationId;
            Is_Working = is_Working;
        }
        public Lift(string name, int stationId, byte is_Working)
        {
            this.Id = LijstSLiften.Count + 1;
            this.Name = name;
            this.StationId = stationId;
            this.Is_Working = is_Working;
        }    
        public byte GetIsWorking()
        {
            return Is_Working;
        }
        public void SetIsWorking(byte isWorking)
        {
            this.Is_Working = isWorking;
        }

        public int GetId()
        {
            return Id;
        }
        public override string? ToString()
        {
            return this.Name;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) { return false; }
            if (!(obj is Lift)) { return false; }
            return (this.Name == ((Lift)obj).Name);
        }
        public static List<Lift> FindLiftsByStationId(Station station)
        {
            List<Lift> lifts = new List<Lift>();
            foreach (Lift lift in Lift.LijstSLiften)
            {
                if (lift.StationId == station.GetStationId())
                {
                    lifts.Add(lift);
                }
            }
            return lifts;
        }
        public static Lift findLiftByName(string naam)
        {
            Lift lift = null;
            foreach (var item in Lift.LijstSLiften)
            {
                if (item.Name == naam)
                {
                    lift = item;
                }
            }
            return lift;
        }
        public static Lift findLiftById(int id)
        {
            Lift lift = null;
            foreach(var item in Lift.LijstSLiften)
            {
                if(item.Id == id)
                {
                    lift = item;
                }
            }
            return lift;
        }

        public void updateLiftDB()
        {
            string dbConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\tijl-\\OneDrive\\Documenten\\Stations.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(dbConnection);
            SqlCommand command = new SqlCommand("UPDATE LIFTEN SET Is_Working = (@working) WHERE Id = (@Id)", connection);
            connection.Open();
            using (command)
            {
                command.Parameters.AddWithValue("@working", this.GetIsWorking());
                command.Parameters.AddWithValue("@Id", this.GetId());
                command.ExecuteNonQuery();
            }
        }
        public void addLiftToDB()
        {
            string dbConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\tijl-\\OneDrive\\Documenten\\Stations.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(dbConnection);
            SqlCommand command = new SqlCommand("INSERT INTO Liften (Id,Naam,Station_id,Is_Working) VALUES(@Id,@Naam,@StationId,@Is_Working)", connection);
            connection.Open();
            command.Parameters.AddWithValue("@Id", this.Id);
            command.Parameters.AddWithValue("@Naam", this.Name);
            command.Parameters.AddWithValue("@StationId", this.StationId);
            command.Parameters.AddWithValue("@Is_Working", this.Is_Working);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

