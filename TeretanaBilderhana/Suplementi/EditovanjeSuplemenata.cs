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
    public partial class EditovanjeSuplemenata : Form
    {
        public EditovanjeSuplemenata()
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
            return (
                (errorProvider1.GetError(tipsuplementa_combo) == "") &&
                (errorProvider1.GetError(suplementID_masked_box) == "")
            );
        }
        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.SuplementDAO c = d.getDAO.getSuplementDAO();

                Suplement Suplement = c.getById(Convert.ToInt32(suplementID_masked_box.Text));
                Suplement.Kolicina = Convert.ToInt32(kolicina_numeric.Value);
                Suplement.Cijena = Convert.ToInt32(cijena_numeric.Value);
                Suplement.TipSuplementaS = tipsuplementa_combo.Text;

                c.update(Suplement);
                d.terminirajKonekciju();
                Close();
            }
        }
        private void suplementID_Validating(object sender, CancelEventArgs e)
        {
            if (suplementID_masked_box.Text.Length != 4)
            {
                errorProvider1.SetError(suplementID_masked_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(suplementID_masked_box, "");
                toolStripStatusLabel1.Text = "";
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
        public bool imaSuplementa()
        {
            if (suplementID_masked_box.Text == "")
                return false;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.SuplementDAO c = d.getDAO.getSuplementDAO();

            try
            {
                c.getById(Convert.ToInt32(suplementID_masked_box.Text));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }

            d.terminirajKonekciju();
            return true;
        }
        private void suplementID_masked_box_Leave(object sender, EventArgs e)
        {
            if (imaSuplementa())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.SuplementDAO c = d.getDAO.getSuplementDAO();

                Suplement Suplement = c.getById(Convert.ToInt32(suplementID_masked_box.Text));
                kolicina_numeric.Value = Suplement.Kolicina;
                cijena_numeric.Value = Suplement.Cijena;
                tipsuplementa_combo.Text = Suplement.TipSuplementaS;
                d.terminirajKonekciju();
            }
            else
                MessageBox.Show("Unesi ispravan ID!");
        }
        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
