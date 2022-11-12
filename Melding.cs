using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvanced_Examen
{
    public class Melding
    {
        public static List<Melding> Meldingen = new List<Melding>();
        public Lift lift;
        private int id;
        private string uitleg;
        private DateTime date;

        public Melding(Lift lift,string uitleg, DateTime date)
        {
            this.lift = lift;
            this.id = Meldingen.Count + 1;
            this.uitleg = uitleg;
            this.date = date;
        }
    }
}
