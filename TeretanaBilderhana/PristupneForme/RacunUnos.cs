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
    public partial class RacunUnos : Form
    {
        public RacunUnos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            comboBox1.SelectedIndex = -1;
            radioButton1.Checked = true;
            numericUpDown4.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RacunPrikaz r = new RacunPrikaz();
            r.Show();
        }

        public int Kolicina()
        {
            return Convert.ToInt32(numericUpDown4.Value);
        }

        public decimal Cijena()
        {
            return numericUpDown1.Value;
        }

        public decimal Za_platiti()
        {
            return numericUpDown3.Value;
        }
    }
}
