using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana.Sprave
{
    public partial class EditovanjeSprava : Form
    {
        public EditovanjeSprava()
        {
            InitializeComponent();
            tipsprave_combo.Items.Add("WeightLifting Sprave");
            tipsprave_combo.Items.Add("Kardio Sprave");
            tipsprave_combo.Items.Add("Sto Za Masazu");
        }
        public bool validiraj() { 
            return (
                (errorProvider1.GetError(tipsprave_combo)=="") &&
                (errorProvider1.GetError(spravaID_masked_box) == "")
            );
        }
        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.SpravaDAO c = d.getDAO.getSpravaDAO();

                Sprava Sprava = c.getById(Convert.ToInt32(spravaID_masked_box.Text));
                Sprava.Kolicina = Convert.ToInt32(kolicina_numeric.Value);
                Sprava.Starost = Convert.ToInt32(starost_numeric.Value);
                Sprava.TipSpraveS = tipsprave_combo.Text;

                c.update(Sprava);
                d.terminirajKonekciju();
                Close();
            }
        }
        private void spravaID_Validating(object sender, CancelEventArgs e)
        {
            if (spravaID_masked_box.Text.Length != 4)
            {
                errorProvider1.SetError(spravaID_masked_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(spravaID_masked_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void tipsprave_Validating(object sender, CancelEventArgs e)
        {
            if (tipsprave_combo.SelectedItem == null)
            {
                errorProvider1.SetError(tipsprave_combo, "Odaberite tip sprave!");
                toolStripStatusLabel1.Text = "Odaberite tip sprave!";
            }
            else
            {
                errorProvider1.SetError(tipsprave_combo, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        public bool imaSprava()
        {
            if (spravaID_masked_box.Text == "")
                return false;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.SpravaDAO c = d.getDAO.getSpravaDAO();

            try
            {
                c.getById(Convert.ToInt32(spravaID_masked_box.Text));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }

            d.terminirajKonekciju();
            return true;
        }
        private void spravaID_masked_box_Leave(object sender, EventArgs e)
        {
            if (imaSprava())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.SpravaDAO c = d.getDAO.getSpravaDAO();

                Sprava Sprava = c.getById(Convert.ToInt32(spravaID_masked_box.Text));
                kolicina_numeric.Value = Sprava.Kolicina;
                starost_numeric.Value = Sprava.Starost;
                tipsprave_combo.Text = Sprava.TipSpraveS;
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
