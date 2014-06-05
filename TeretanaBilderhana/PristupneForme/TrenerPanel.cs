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
            EditovanjeUposlenika ex = new EditovanjeUposlenika();
            ex.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // PREGLED UPOSLENIKA
        }

        private void toolStripButton1_MouseHover(object sender, EventArgs e)
        {
            toolStripButton1.ToolTipText = "Pregled uposlenih";
        }

        private void toolStripButton2_MouseHover(object sender, EventArgs e)
        {
            toolStripButton2.ToolTipText = "Editovanje klijenata";
        }
    }
}
