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
            d.kreirajKonekciju("localhost", "i-videoteka", "root", "");
            DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

            try
            {
                c.getById(Convert.ToInt32(IDtextbox.Text));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }

            d.terminirajKonekciju();
            return true;
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            if (konektovan()) 
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "i-videoteka", "root", "");

                DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();
                Uposlenik radnik = c.getById(Convert.ToInt32(IDtextbox.Text));

                if (radnik.Sifra == passtextbox.Text)
                {
                    MainPage f = new MainPage();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Neispravna šifra!");
                }
                d.terminirajKonekciju();
            }
            else
            {
                MessageBox.Show("Neispravan ID!");
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
