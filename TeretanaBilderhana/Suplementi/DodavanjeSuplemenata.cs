using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana.Suplementi
{
    public partial class DodavanjeSuplemenata : Form
    {
        public DodavanjeSuplemenata()
        {
            InitializeComponent();
            tipsuplementa_combo.Items.Add("Protein");
            tipsuplementa_combo.Items.Add("Kreatin");
            tipsuplementa_combo.Items.Add("Aminokiseline");
            tipsuplementa_combo.Items.Add("Fatburner");
            tipsuplementa_combo.Items.Add("Massgainer");
            tipsuplementa_combo.Items.Add("Preworkout");
        }
        public bool validiraj()
        {
            return
            (
                (errorProvider1.GetError(tipsuplementa_combo)=="")
            );
        }
        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                Random id = new Random();
                int r = id.Next(1111, 9999);
                Suplement Suplement = new Suplement(r, Convert.ToInt32(kolicina_numeric.Value), cijena_numeric.Value, 
                    tipsuplementa_combo.Text);

                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.SuplementDAO c = d.getDAO.getSuplementDAO();
                MessageBox.Show(Suplement.TipSuplementa + " " + Suplement.TipSuplementaS);
                Suplement.IdSuplementa = (int)c.create(Suplement);
                d.terminirajKonekciju();
                MessageBox.Show("Suplement unesena! ID je: " + r);
                Close();
            }
        }
        private void tipsuplementa_Validating(object sender, CancelEventArgs e)
        {
            if (tipsuplementa_combo.SelectedItem == null)
            {
                errorProvider1.SetError(tipsuplementa_combo, "Odaberite tip suplementa!");
                toolStripStatusLabel1.Text = "Odaberite tip suplementa!";
            }
            else
            {
                errorProvider1.SetError(tipsuplementa_combo, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
