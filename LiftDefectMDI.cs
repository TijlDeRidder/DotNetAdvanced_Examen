using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetAdvanced_Examen
{
    public partial class LiftDefectMDI : Form
    {
        private Lift lift;

        public LiftDefectMDI(Lift huidig)
        {
            this.lift = huidig;
            InitializeComponent();
        }

        private void b_melden_Click(object sender, EventArgs e)
        {
            DateTime date = dtp_defect_date.Value;
            String uitleg = rtb_uitleg.Text;
            Melding huidigeMelding = new Melding(lift,uitleg,date);
            Melding.Meldingen.Add(huidigeMelding);

        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
