using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeretanaBilderhana;

namespace TeretanaBilderhana.PristupneForme
{
    public partial class TrenerPanel : Form
    {
        public TrenerPanel()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DosijeKlijentaT t = new DosijeKlijentaT();
            t.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DosijeKlijentaT dk = new DosijeKlijentaT();
            dk.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            IzvjestajForma f = new IzvjestajForma();
            f.Show();
        }
    }
}
