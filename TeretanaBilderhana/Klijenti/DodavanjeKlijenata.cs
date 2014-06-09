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

namespace TeretanaBilderhana.Klijenti
{
    public partial class DodavanjeKlijenata : Form
    {
        List<Uposlenik> Uposlenici;
        public DodavanjeKlijenata()
        {
            InitializeComponent();
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();
            Uposlenici = c.GetAll();
            d.terminirajKonekciju();

            foreach (Uposlenik u in Uposlenici)
            {
                if (u.ZaposlenjeS == "Trener") trener_combo.Items.Add(u);
                else if (u.ZaposlenjeS == "Nutricionista") nutricionista_combo.Items.Add(u);
            }
        }

        public bool validiraj()
        {
            return
            (
                (errorProvider1.GetError(imetb) == "") &&
                (errorProvider1.GetError(prezimetb) == "") &&
                (errorProvider1.GetError(kontakttb) == "") &&
                (errorProvider1.GetError(trenerID_masked_box) == "") &&
                (errorProvider1.GetError(nutricionstaID_masked_box) == "") &&
                (errorProvider1.GetError(groupBox2) == "")
            );
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj() && imaNutricioniste() && imaTrenera())
            {
                String Spol="Musko";
                Random id = new Random();
                int r = id.Next(1111, 9999);
                if(zenskoRB.Checked) Spol="Zensko"; 
                Klijent k = new Klijent(
                    r, imetb.Text, prezimetb.Text, Spol, datumRodjenjadtp.Value, Convert.ToInt32(visina_numeric.Value), 
                    tezina_numeric.Value, kontakttb.Text, Convert.ToInt32(trenerID_masked_box.Text),
                    Convert.ToInt32(nutricionstaID_masked_box.Text));

                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.KlijentDAO c = d.getDAO.getKlijentDAO();

                k.ID = (int)c.create(k);
                d.terminirajKonekciju();
                MessageBox.Show("Klijent unesen! ID je: " + r);
                Close();
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
                errorProvider1.SetError(prezimetb, "Prezime prekratko");
                toolStripStatusLabel1.Text = "Prezime prekratko!";
            }
            else
            {
                errorProvider1.SetError(prezimetb, "");
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
        private void Spol_Validating(object sender, CancelEventArgs e)
        {
            if (muskoRB.Checked == false && zenskoRB.Checked == false)
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
        private void trenerID_Validating(object sender, CancelEventArgs e)
        {
            if (trenerID_masked_box.Text.Length != 4 )
            {
                errorProvider1.SetError(trenerID_masked_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(trenerID_masked_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void nutricionistaID_Validating(object sender, CancelEventArgs e)
        {
            if (nutricionstaID_masked_box.Text.Length != 4)
            {
                errorProvider1.SetError(nutricionstaID_masked_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(nutricionstaID_masked_box, "");
                toolStripStatusLabel1.Text = "";
            }
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
                    Uposlenik radnik = c.getById(Convert.ToInt32(trenerID_masked_box.Text));
                    if (radnik.ZaposlenjeS == "Trener")
                    {
                        d.terminirajKonekciju();
                        return true;
                    }
                    else
                    {
                        d.terminirajKonekciju();
                        return false;
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    d.terminirajKonekciju();
                    return false;
                }
            }
            else return false;
        }
        public bool imaNutricioniste()
        {
            if (nutricionstaID_masked_box.Text.Length == 4)
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

                try
                {
                    Uposlenik radnik = c.getById(Convert.ToInt32(nutricionstaID_masked_box.Text));
                    if (radnik.ZaposlenjeS == "Nutricionista")
                    {
                        d.terminirajKonekciju();
                        return true;
                    }
                    else
                    {
                        d.terminirajKonekciju();
                        return false;
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    d.terminirajKonekciju();
                    return false;
                }
            }
            else return false;
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trener_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            trenerID_masked_box.Text = Convert.ToString(trener_combo.Text);
        }

        private void nutricionista_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nutricionstaID_masked_box.Text = Convert.ToString(nutricionista_combo.Text);
        }
    }
}
