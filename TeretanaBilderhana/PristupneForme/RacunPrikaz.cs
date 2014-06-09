using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana.PristupneForme
{
    public partial class RacunPrikaz : Form
    {
        private string p1;
        private decimal p2;
        private int p3;
        private decimal p4;

        public RacunPrikaz()
        {
            InitializeComponent();
        }

        public RacunPrikaz(string p1, decimal p2, int p3, decimal p4)
        {
            // TODO: Complete member initialization
            this.p1 = p1; // usluga
            this.p2 = p2; // cijena
            this.p3 = p3; // kolicina
            this.p4 = p4; // za platiti
            InitializeComponent();
        }

        private void Racun_Load(object sender, EventArgs e)
        {
            label19.Text = Convert.ToString(DateTime.Now);
            RacunUnos r1 = new RacunUnos();
            label36.Text = Convert.ToString(r1.Za_platiti());
            label37.Text = Convert.ToString(r1.Za_platiti());
            label38.Text = Convert.ToString(r1.Za_platiti());

            label33.Text = Convert.ToString(r1.Za_platiti() - (r1.Za_platiti() * 0.17m));
            label34.Text = Convert.ToString(r1.Za_platiti() * 0.17m);
            label35.Text = Convert.ToString(r1.Za_platiti() * 0.17m);

            label22.Text = Convert.ToString(r1.Kolicina());
            label23.Text = Convert.ToString(r1.Cijena());
            label24.Text = Convert.ToString(r1.Za_platiti()) + "E";
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
