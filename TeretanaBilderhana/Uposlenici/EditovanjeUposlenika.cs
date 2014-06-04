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

namespace TeretanaBilderhana
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
                (errorProvider1.GetError(kontakt_masked_box) == "") &&
                (errorProvider1.GetError(sifra_box) == "") &&
                (errorProvider1.GetError(zaposlenje_combo) == "") &&
                (errorProvider1.GetError(groupBox2) == "")
            );
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                String zaposlenje = zaposlenje_combo.SelectedValue as String;
                String Spol="Musko";
                if(zenskoRB.Checked) Spol="Zensko";
               
                Uposlenik Uposlenik = new Uposlenik(
                    Convert.ToInt32(uposlenikID_masked_box.Text), imetb.Text, prezimetb.Text, Spol, rodjenje_datetime.Value, 
                    zaposlenje_datetime.Value, plata_npd.Value, kontakt_masked_box.Text, zaposlenje, sifra_box.Text);

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

        private void sifratb_Validating(object sender, CancelEventArgs e)
        {
            if (sifra_box.Text.Length < 5)
            {
                errorProvider1.SetError(sifra_box, "Prekratka sifra!");
                toolStripStatusLabel1.Text = "Prekratka sifra!";
            }
            else
            {
                errorProvider1.SetError(sifra_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }

        private void Spol_Validating(object sender, CancelEventArgs e)
        {
            if (muskoRB.Checked==false && zenskoRB.Checked==false)
            {
                errorProvider1.SetError(groupBox2, "Odaberite spol!");
                toolStripStatusLabel1.Text = "Odaberite spol!";
            }
            else
            {
                errorProvider1.SetError(groupBox2, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void kontakttb_Validating(object sender, CancelEventArgs e)
        {
            if (kontakt_masked_box.Text.Length != 9)
            {
                errorProvider1.SetError(kontakt_masked_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(kontakt_masked_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }

        private void zaposlenje_Validating(object sender, CancelEventArgs e)
        {
            if (zaposlenje_combo.SelectedItem==null)
            {
                errorProvider1.SetError(zaposlenje_combo, "Odaberite zaposlenje!");
                toolStripStatusLabel1.Text = "Odaberite zaposlenje!";
            }
            else
            {
                errorProvider1.SetError(zaposlenje_combo, "");
                toolStripStatusLabel1.Text = "";
            }
        }

        public bool ima()
        {
            if (uposlenikID_masked_box.Text == "")
                return false;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

            try
            {
                c.getById(Convert.ToInt32(uposlenikID_masked_box.Text));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }

            d.terminirajKonekciju();
            return true;
        }

        private void uposlenikID_masked_box_Leave(object sender, EventArgs e)
        {
            if (ima())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

                Uposlenik Uposlenik = c.getById(Convert.ToInt32(uposlenikID_masked_box.Text));
                imetb.Text = Uposlenik.Ime;
                prezimetb.Text = Uposlenik.Prezime;
                if (Convert.ToString(Uposlenik.Spol) == "Musko") muskoRB.Checked = true;
                else zenskoRB.Checked = true;
                rodjenje_datetime.Value = Uposlenik.DatumRodjenja;
                kontakt_masked_box.Text = Uposlenik.Kontakt;
                plata_npd.Value = Uposlenik.Plata;
                zaposlenje_datetime.Value = Uposlenik.DatumZaposlenja;
                zaposlenje_combo.SelectedText = Uposlenik.ZaposlenjeS;
                sifra_box.Text = Uposlenik.Sifra;
                d.terminirajKonekciju();
            }
            else
                MessageBox.Show("Unesi ispravan ID!");
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditovanjeUposlenika_Load(object sender, EventArgs e)
        {

        }

    }
}
