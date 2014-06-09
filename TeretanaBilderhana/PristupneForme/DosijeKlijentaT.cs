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
    public partial class DosijeKlijentaT : Form // FALI POVEZIVANJE ID - KLIJENT
    {
        public DosijeKlijentaT()
        {
            InitializeComponent();
            DAL.DAL d = DAL.DAL.Instanca;
            d.terminirajKonekciju();
        }

        public bool validiraj()
        {
            return
            (
                (errorProvider1.GetError(imetb) == "") &&
                (errorProvider1.GetError(prezimetb) == "") &&
                (errorProvider1.GetError(kontakttb) == "") &&
                (errorProvider1.GetError(trenerID_masked_box) == "") &&
                (errorProvider1.GetError(nutricionistaID_masked_box) == "") &&
                (errorProvider1.GetError(groupBox2) == "")
            );
        }

        public bool imaKlijenta()
        {
            if (klijentID_masked_box.Text == "")
                return false;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.KlijentDAO c = d.getDAO.getKlijentDAO();

            try
            {
                c.getById(Convert.ToInt32(klijentID_masked_box.Text));
            }
            catch (System.Exception ex)
            {
                d.terminirajKonekciju();
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }

            d.terminirajKonekciju();
            return true;
        }
        public bool imaTrenera()
        {
            if (trenerID_masked_box.Text.Length == 4)
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

                try
                {
                    c.getById(Convert.ToInt32(trenerID_masked_box.Text));
                }
                catch (System.Exception ex)
                {
                    d.terminirajKonekciju();

                    MessageBox.Show(Convert.ToString(ex));
                    return false;
                }
                d.terminirajKonekciju();
                return true;
            }
            else return false;
        }
        public bool imaNutricioniste()
        {
            if (nutricionistaID_masked_box.Text.Length == 4)
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

                try
                {
                    c.getById(Convert.ToInt32(nutricionistaID_masked_box.Text));
                }
                catch (System.Exception ex)
                {
                    d.terminirajKonekciju();
                    MessageBox.Show(Convert.ToString(ex));
                    return false;
                }
                d.terminirajKonekciju();
                return true;
            }
            else return false;
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj() && imaNutricioniste() && imaTrenera())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.KlijentDAO c = d.getDAO.getKlijentDAO();

                Klijent Klijent = c.getById(Convert.ToInt32(klijentID_masked_box.Text));
                Klijent.Ime = imetb.Text;
                Klijent.Prezime = prezimetb.Text;
                if (muskoRB.Checked == true) Klijent.Spol = Spol.Musko;
                else Klijent.Spol = Spol.Zensko;
                Klijent.Kontakt = kontakttb.Text;
                Klijent.IDnutricioniste = Convert.ToInt32(nutricionistaID_masked_box.Text);
                Klijent.IDtrenera = Convert.ToInt32(trenerID_masked_box.Text);
                //MessageBox.Show(zaposlenje_combo.Text);
                c.update(Klijent);
                d.terminirajKonekciju();
                //Close();
            }
        }

        private void klijentID_masked_box_Leave(object sender, EventArgs e)
        {
            if (imaKlijenta())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.KlijentDAO c = d.getDAO.getKlijentDAO();

                Klijent Klijent = c.getById(Convert.ToInt32(klijentID_masked_box.Text));
                string rodjenje = Convert.ToString(Klijent.DatumRodjenja);
                imetb.Text = Klijent.Ime;
                prezimetb.Text = Klijent.Prezime;
                if (Convert.ToString(Klijent.Spol) == "Musko") muskoRB.Checked = true;
                else zenskoRB.Checked = true;
                datumRodjenjadtp.Value = DateTime.Parse(rodjenje);
                kontakttb.Text = Klijent.Kontakt;
                trenerID_masked_box.Text = Convert.ToString(Klijent.IDtrenera);
                nutricionistaID_masked_box.Text = Convert.ToString(Klijent.IDnutricioniste);
                d.terminirajKonekciju();
            }
            else
                MessageBox.Show("Unesi ispravan ID!");
        }

        private void klijentID_masked_box_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
