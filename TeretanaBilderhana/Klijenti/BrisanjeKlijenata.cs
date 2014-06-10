using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana.Klijenti
{
    public partial class BrisanjeKlijenata : Form
    {
        public BrisanjeKlijenata()
        {
            InitializeComponent();
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
                numericUpDown1.Value = Klijent.Visina;
                d.terminirajKonekciju();
                toolStripStatusLabel1.Text = "";
            }
            else
                MessageBox.Show("Unesi ispravan ID!");

        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            //// NE VALJA OVO JOŠ
        }
    }
}
