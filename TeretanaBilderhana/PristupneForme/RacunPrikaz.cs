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
        public RacunPrikaz()
        {
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


    }
}
