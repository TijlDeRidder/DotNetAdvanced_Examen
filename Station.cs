﻿using System;
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

        public override string? ToString()
        {
            return this.Name;
        }
        public override bool Equals(object? obj)
        {
        if(obj == null) { return false; }
        if (!(obj is Station)) { return false; }
        return (this.Name ==((Station)obj).Name);
        }

    }

}