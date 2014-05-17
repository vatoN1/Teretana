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
    public partial class DodavanjeUposlenika : Form
    {
        public DodavanjeUposlenika()
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
                (errorProvider1.GetError(IDtb) == "") && 
                (errorProvider1.GetError(platatb) == ""));
        }


        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                String zaposlenje = zaposlenjecb.SelectedValue as String;
                String Spol="Musko";
                Random id = new Random();
                int r = id.Next(11111, 99999);
                if(zenskoRB.Checked) Spol="Zensko"; 
                Uposlenik Uposlenik = new Uposlenik(
                    r, imetb.Text, prezimetb.Text, Spol, datumRodjenjadtp.Value, datumZaposlenjadtp.Value,
                    Convert.ToDecimal(platatb.Text), kontakttb.Text, zaposlenje, sifratb.Text);

                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "i-videoteka", "root", "");

                DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

                Uposlenik.IdUposlenika = (int)c.create(Uposlenik);
                d.terminirajKonekciju();
                MessageBox.Show("Uposlenik unesen! ID je: " + r);
                Close();

            }
        }

        private void IDtb_Validating(object sender, CancelEventArgs e)
        {
            if (IDtb.Text.Length < 4)
            {
                errorProvider1.SetError(IDtb, "Ime prekratko");
                toolStripStatusLabel1.Text = "Ime prekratko!";
            }
            else
            {
                errorProvider1.SetError(IDtb, "");
                toolStripStatusLabel1.Text = "";
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

        
    }
}
