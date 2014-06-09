using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace TeretanaBilderhana.PristupneForme
{
    public partial class RacunUnos : Form
    {
        private List<Suplement> suplementi;
        public RacunUnos()
        {
            InitializeComponent();
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.SuplementDAO c = d.getDAO.getSuplementDAO();
            suplementi = c.GetAll();
            d.terminirajKonekciju();

            foreach (Suplement u in suplementi)
            {
                comboBox2.Items.Add(u);
            }
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
            RacunPrikaz r = new RacunPrikaz(comboBox2.Text, numericUpDown1.Value, Convert.ToInt32(numericUpDown4.Value), numericUpDown3.Value);
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
            decimal dajPare = numericUpDown3.Value;
            if (radioButton1.Checked == true && groupBox2.Enabled == true)
                dajPare /= 0.17m;
            return dajPare;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Registracija klijenta")
            {
                numericUpDown1.Value = 3000.00m;
                numericUpDown4.Value = 1;
                numericUpDown4.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton1.Checked = true;
                numericUpDown3.Value = numericUpDown1.Value * numericUpDown4.Value;
            }
            else if (comboBox1.Text == "Jednokratni termin")
            {
                numericUpDown4.Enabled = false;
                numericUpDown1.Value = 100.00m;
                groupBox2.Enabled = false;
                numericUpDown3.Value = numericUpDown1.Value * numericUpDown4.Value;
                
            }
            else if (comboBox1.Text == "Kupovina suplemenata")
            {
                numericUpDown4.Enabled = true;
                comboBox1.Visible = false;
                comboBox2.Visible = true;
                label6.Visible = true;
                label1.Visible = false;
            }
            else if (comboBox1.Text == "Iznajmljivanje opreme")
            {
                numericUpDown4.Enabled = true;
                // SLICNO KAO ZA SUPLEMENTE
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Suplement s in suplementi)
            {
                if (comboBox2.Text == s.ToString())
                    numericUpDown3.Value = s.Cijena*numericUpDown4.Value;
            }
            foreach (Suplement s in suplementi)
            {
                if (comboBox2.SelectedItem == s)
                {
                    numericUpDown1.Value = s.Cijena;
                }
            }

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            foreach (Suplement s in suplementi)
            {
                if (comboBox2.Text == s.ToString())
                    numericUpDown3.Value = numericUpDown1.Value * numericUpDown4.Value;
                if (radioButton1.Checked == true)
                    numericUpDown3.Value -= numericUpDown3.Value*0.17m;
            }   
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                numericUpDown3.Value = numericUpDown1.Value * numericUpDown4.Value;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                numericUpDown3.Value -= numericUpDown3.Value * 0.17m;
        }
    }
}
