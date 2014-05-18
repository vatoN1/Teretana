using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana.Uposlenici
{
    public partial class EditovanjeUposlenika : Form
    {
        public EditovanjeUposlenika()
        {
            InitializeComponent();
        }

        public bool validiraj()
        {
            return (
                (errorProvider1.GetError(imetb) == "") &&
                (errorProvider1.GetError(prezimetb) == "") &&
                (errorProvider1.GetError(kontakttb) == "") &&
                (errorProvider1.GetError(sifratb) == "") &&
                (errorProvider1.GetError(platatb) == "")
            );
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                String zaposlenje = zaposlenjecb.SelectedValue as String;
                String Spol="Musko";
                if(zenskoRB.Checked) Spol="Zensko";
               
                Uposlenik Uposlenik = new Uposlenik(
                    Convert.ToInt32(maskedTextBox1.Text), imetb.Text, prezimetb.Text, Spol, datumRodjenjadtp.Value, datumZaposlenjadtp.Value,
                    Convert.ToDecimal(platatb.Text), kontakttb.Text, zaposlenje, sifratb.Text);

                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

                c.update(Uposlenik.IdUposlenika, Uposlenik);
                d.terminirajKonekciju();
                Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Unesite ispravne podatke!";
            }
        }

        private void imetb_Validating(object sender, CancelEventArgs e)
        {
            if (imetb.Text.Length < 3)
            {
                errorProvider1.SetError(imetb, "Ime prekratko");
                toolStripStatusLabel1.Text = "Ime prekratko!";
            }
            else
            {
                errorProvider1.SetError(imetb, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void prezimetb_Validating(object sender, CancelEventArgs e)
        {
            if (prezimetb.Text.Length < 3)
            {
                errorProvider1.SetError(prezimetb, "Ime prekratko");
                toolStripStatusLabel1.Text = "Ime prekratko!";
            }
            else
            {
                errorProvider1.SetError(prezimetb, "");
                toolStripStatusLabel1.Text = "";
            }
        }

        private void platatb_Validating(object sender, CancelEventArgs e)
        {
            if (prezimetb.Text.Length < 3)
            {
                errorProvider1.SetError(prezimetb, "Premala plata!");
                toolStripStatusLabel1.Text = "Premala plata!";
            }
            else
            {
                errorProvider1.SetError(prezimetb, "");
                toolStripStatusLabel1.Text = "";
            }
        }

        private void sifratb_Validating(object sender, CancelEventArgs e)
        {
            if (sifratb.Text.Length < 5)
            {
                errorProvider1.SetError(sifratb, "Prekratka sifra!");
                toolStripStatusLabel1.Text = "Prekratka sifra!";
            }
            else
            {
                errorProvider1.SetError(sifratb, "");
                toolStripStatusLabel1.Text = "";
            }
        }

        private void kontakttb_Validating(object sender, CancelEventArgs e)
        {
            if (kontakttb.Text.Length != 9)
            {
                errorProvider1.SetError(kontakttb, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(kontakttb, "");
                toolStripStatusLabel1.Text = "";
            }
        }

        public bool ima()
        {
            if (maskedTextBox1.Text == "")
                return false;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

            try
            {
                c.getById(Convert.ToInt32(maskedTextBox1.Text));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }

            d.terminirajKonekciju();
            return true;
        }

        private void maskedTextBox4_Leave(object sender, EventArgs e)
        {
            if (ima())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

                Uposlenik Uposlenik = c.getById(Convert.ToInt32(maskedTextBox1.Text));
                imetb.Text = "";
                prezimetb.Text = "";
                kontakttb.Text = "";
                platatb.Text = "";
                datumRodjenjadtp.Value = Uposlenik.DatumRodjenja;
                datumZaposlenjadtp.Value = Uposlenik.DatumZaposlenja;
                if (Convert.ToString(Uposlenik.Spol) == "Musko") muskoRB.Checked = true;
                else zenskoRB.Checked = false; 
                

                d.terminirajKonekciju();
            }
            else
                MessageBox.Show("Unesi ispravan ID!");
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
