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
        public DodavanjeKlijenata()
        {
            InitializeComponent();
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
            if (validiraj())
            {
                String Spol="Musko";
                Random id = new Random();
                int r = id.Next(1111, 9999);
                if(zenskoRB.Checked) Spol="Zensko"; 
                Klijent k = new Klijent(
                    r, imetb.Text, prezimetb.Text, Spol, datumRodjenjadtp.Value, 
                    kontakttb.Text,Convert.ToInt32(trenerID_masked_box.Text),Convert.ToInt32(nutricionstaID_masked_box.Text) );

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
                errorProvider1.SetError(prezimetb, "Ime prekratko");
                toolStripStatusLabel1.Text = "Ime prekratko!";
            }
            else
            {
                errorProvider1.SetError(prezimetb, "");
                toolStripStatusLabel1.Text = "";
            }
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
