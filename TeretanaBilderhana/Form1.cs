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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int triger = 1;
            try
            {
                if (usertext.Text == "teretana" && passtext.Text == "bilderhana")
                {
                    Form2 f = new Form2();
                    f.Show();
                }
                else if (usertext.Text == "teretana" && passtext.Text != "bilderhana")
                {
                    errorProvider1.SetError(usertext, "");
                    errorProvider1.SetError(passtext, "Pogresna sifra");
                }
                else if (usertext.Text != "teretana" && passtext.Text == "bilderhana")
                {
                    errorProvider1.SetError(usertext, "Pogresan korisnicki nalog");
                    errorProvider1.SetError(passtext, "");
                }
                else
                {

                    bool flag = false;
                    for (int i = 0; i < passtext.Text.Length; i++)
                    {
                        char x = Convert.ToChar(passtext.Text[i]);
                        if (!IsLetterOrDigit(x))
                        {
                            flag = true;
                        }
                    }
                    baciIzuzetak(flag);

                    errorProvider1.SetError(usertext, "Pogresan korisnicki nalog");
                    errorProvider1.SetError(passtext, "Pogresna sifra");
                }
            }
            catch (Exception)
            {
            }
       
        }

        bool IsLetterOrDigit(char c) { return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'); }
        private void baciIzuzetak(bool flag)
        {
            if (flag == true) throw new Exception("HAJD BAR NEŠTO IZBACI");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
