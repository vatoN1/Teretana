using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana.Izvjestaji
{
    public partial class DodavanjeIzvjestaja : Form
    {
        public DodavanjeIzvjestaja()
        {
            InitializeComponent();
        }

        public bool validiraj()
        {
            return
            (
                (errorProvider1.GetError(id_uposlenik_masked_box) == "") &&
                (errorProvider1.GetError(sadrzaj_rich_box) == "")
            );
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj() && imaUposlenika())
            {
                Random id = new Random();
                int r = id.Next(1111, 9999);
                Izvjestaj Izvjestaj = new Izvjestaj(
                    r, Convert.ToInt32(id_uposlenik_masked_box.Text), izvjestaj_datetime.Value , 
                    sadrzaj_rich_box.Text);

                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.IzvjestajDAO c = d.getDAO.getIzvjestajDAO();

                Izvjestaj.IdIzvjestaja = (int)c.create(Izvjestaj);
                d.terminirajKonekciju();
                MessageBox.Show("Izvjestaj unesen! ID je: " + r);
                Close();
            }
        }
        private void uposlenikID_Validating(object sender, CancelEventArgs e)
        {
            if (id_uposlenik_masked_box.Text.Length != 4)
            {
                errorProvider1.SetError(id_uposlenik_masked_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(id_uposlenik_masked_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void sadrzaj_rich_box_Validating(object sender, CancelEventArgs e)
        {
            if (sadrzaj_rich_box.Text.Length < 10)
            {
                errorProvider1.SetError(sadrzaj_rich_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Sadrzaj treba da sadrzava makar 10 karaktera!";
            }
            else
            {
                errorProvider1.SetError(sadrzaj_rich_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        public bool imaUposlenika()
        {
            if (id_uposlenik_masked_box.Text.Length == 4)
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

                try
                {
                    c.getById(Convert.ToInt32(id_uposlenik_masked_box.Text));
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    return false;
                }
                d.terminirajKonekciju();
                return true;
            }
            else return false;
        }
        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
