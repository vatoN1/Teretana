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

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label19_TextChanged(object sender, EventArgs e)
        {

        }

        private void Racun_Load(object sender, EventArgs e)
        {
            label19.Text = Convert.ToString(DateTime.Now);
        }
    }
}
