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
    public partial class Recepcija : Form
    {
        public Recepcija()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_MouseHover(object sender, EventArgs e)
        {
            toolStripButton1.Text = "Unos novog klijenta";
        }

        private void toolStripButton2_MouseHover(object sender, EventArgs e)
        {
            toolStripButton2.Text = "Formiranje racuna za jednokratnog korisnika";
        }

        private void toolStripButton3_MouseHover(object sender, EventArgs e)
        {
            toolStripButton3.Text = "Recepcioner izvjestaj";
        }
    }
}
