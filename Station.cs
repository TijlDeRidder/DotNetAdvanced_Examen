using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvanced_Examen
{
    public class Station
    {
        public static List<Station> LijstStation = new List<Station>();
        private int Id { get; set; }
        private string Name { get; set; }
        private byte Is_Accecible;
        private byte Has_Elevator;

        public Station(int id, string name, byte is_Accecible, byte has_Elevator)
        {
            Id = id;
            Name = name;
            Is_Accecible = is_Accecible;
            Has_Elevator = has_Elevator;
        }

        public Station(string name, byte is_Accecible, byte has_Elevator)
        {
            this.Id = Station.LijstStation.Count + 1;
            this.Name = name;
            this.Is_Accecible = is_Accecible;
            this.Has_Elevator = has_Elevator;
        }

        public override string? ToString()
        {
            return this.Name;
        }

        public int GetStationId()
        {
            return Id;
        }
        public byte GetIsAccecible()
        {
            return Is_Accecible;
        }
        public byte GetHasElevator()
        {
            return Has_Elevator;
        }
        public override bool Equals(object? obj)
        {
        if(obj == null) { return false; }
        if (!(obj is Station)) { return false; }
        return (this.Name ==((Station)obj).Name);
        }

        public static Station findStationByName(string naam)
        {
            Station station = null;
            foreach (var item in Station.LijstStation)
            {
                if (item.Name == naam)
                {
                    station = item;
                }
            }
            return station;
        }
        public static Station findStationById(int id)
        {
            Station station = null;
            foreach (var item in Station.LijstStation)
            {
                if (item.GetStationId() == id)
                {
                    station = item;
                }
            }
            return station;
        }
        public void addStationToDB()
        {
            string info = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\", "Stations.mdf"));
            string dbConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                        $"AttachDbFilename={info};" +
                                        "Integrated Security=True;" +
                                        "Connect Timeout=30";
            SqlConnection connection = new SqlConnection(dbConnection);
            SqlCommand command = new SqlCommand("INSERT INTO STATIONS (Id,Naam,Is_Accecible,Has_Elevator) VALUES(@Id,@Naam,@Is_Accecible,@Has_Elevator)", connection);
            connection.Open();
            command.Parameters.AddWithValue("@Id", this.Id);
            command.Parameters.AddWithValue("@Naam", this.Name);
            command.Parameters.AddWithValue("Is_Accecible", this.Is_Accecible);
            command.Parameters.AddWithValue("@Has_Elevator", this.Has_Elevator);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

