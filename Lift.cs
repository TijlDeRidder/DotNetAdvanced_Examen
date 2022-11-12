using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public Lift(string name, int stationId, byte is_Working)
        {
            Id = LijstSLiften.Count + 1;
            Name = name;
            StationId = stationId;
            Is_Working = is_Working;
        }
        public byte GetIsWorking()
        {
            return Is_Working;
        }
        public void SetIsWorking(byte isWorking)
        {
            Is_Working = isWorking;
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
    }
}

