using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.ExceptionServices;
using DAL;

namespace TeretanaBilderhana
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool konektovan()
        {
            if (IDtextbox.Text == "")
            {
                return false;
            }
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

            try
            {
                c.getById(Convert.ToInt32(IDtextbox.Text));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                d.terminirajKonekciju();
                return false;
            }

            d.terminirajKonekciju();
            return true;
        }


        bool IsLetterOrDigit(char c) 
        { return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'); }
        private void baciIzuzetak(bool flag)
        { if (flag == true) throw new Exception("HAJD BAR NEŠTO IZBACI"); }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (konektovan())
                {
                    DAL.DAL d = DAL.DAL.Instanca;
                    d.kreirajKonekciju("localhost", "Teretana", "root", "");

                    DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();
                    Uposlenik radnik = c.getById(Convert.ToInt32(IDtextbox.Text));

                    if (radnik.Sifra == passtextbox.Text)
                    {
                        DodavanjeUposlenika f = new DodavanjeUposlenika();
                        f.Show();
                        MainPage mp = new MainPage();
                        mp.Show();
                    }
                    else if (Convert.ToInt32(IDtextbox.Text) == radnik.IdUposlenika && passtextbox.Text != radnik.Sifra)
                    {
                        errorProvider1.SetError(IDtextbox, "");
                        errorProvider1.SetError(passtextbox, "Pogresna sifra");
                    }
                    else if (Convert.ToInt32(IDtextbox.Text) != radnik.IdUposlenika && passtextbox.Text == radnik.Sifra)
                    {
                        errorProvider1.SetError(IDtextbox, "Pogresan korisnicki nalog");
                        errorProvider1.SetError(passtextbox, "");
                    }
                    else
                    {
                        MessageBox.Show("Neispravna šifra!");
                    }
                    d.terminirajKonekciju();
                }
                else
                {
                    bool flag = false;
                    for (int i = 0; i < passtextbox.Text.Length; i++)
                    {
                        char x = Convert.ToChar(passtextbox.Text[i]);
                        if (!IsLetterOrDigit(x))
                        {
                            flag = true;
                        }
                    }
                    baciIzuzetak(flag);

                    errorProvider1.SetError(IDtextbox, "Pogresan korisnicki nalog");
                    errorProvider1.SetError(passtextbox, "Pogresna sifra");
                    MessageBox.Show("Neispravan korisnicki nalog i password!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                ;
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
