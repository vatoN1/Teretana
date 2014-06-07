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
    public partial class NutricionistaPanel : Form
    {
        public NutricionistaPanel()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DosijeKlijentaN n = new DosijeKlijentaN();
            n.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Klijenti.EditovanjeKlijenata ex = new Klijenti.EditovanjeKlijenata();
            ex.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            IzvjestajForma f = new IzvjestajForma();
            f.Show();
        }
    }
}
