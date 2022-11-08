using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvanced_Examen
{
    internal class Lift
    {
        public static List<Lift> LijstLift = new List<Lift>();
        private int Id;
        private string Name { get; set; }
        public int StationId { get; set; }
        private byte Is_Working;

        public Lift(int id, string name, int stationId, byte is_Working)
        {
            Id = id;
            Name = name;
            StationId = stationId;
            Is_Working = is_Working;
        }

        public override string? ToString()
        {
            return this.Name;
        }

        public List<Lift> findLiftsByStationId(Station station)
        {
            List<Lift> lifts = new List<Lift>();
            foreach (var lift in Lift.LijstLift)
            {
                if (lift.StationId == Station.Id)
                {
                    lifts.Add(lift);
                }
            }
            return lifts;
        }
    }
}
