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
    public partial class EditovanjeIzvjestaja : Form
    {
        public EditovanjeIzvjestaja()
        {
            InitializeComponent();
        }
        public bool validiraj()
        {
            return
            (
                (errorProvider1.GetError(id_uposlenik_masked_box) == "") &&
                (errorProvider1.GetError(sadrzaj_rich_box) == "") &&
                (errorProvider1.GetError(id_izvjestaj_masked_box)=="")
            );
        }
        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj() && imaIzvjestaja())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.IzvjestajDAO c = d.getDAO.getIzvjestajDAO();

                Izvjestaj Izvjestaj = c.getById(Convert.ToInt32(id_izvjestaj_masked_box.Text));
                Izvjestaj.SadrzajIzvjestaja = sadrzaj_rich_box.Text;
                Izvjestaj.DatumIzvjestaja = izvjestaj_datetime.Value;
                Izvjestaj.IDuposlenik = Convert.ToInt32(id_uposlenik_masked_box.Text);
                c.update(Izvjestaj);
                d.terminirajKonekciju();
                //Close();
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
        private void izvjestajID_Validating(object sender, CancelEventArgs e)
        {
            if (id_izvjestaj_masked_box.Text.Length != 4)
            {
                errorProvider1.SetError(id_izvjestaj_masked_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(id_izvjestaj_masked_box, "");
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
        public bool imaIzvjestaja()
        {
            if (id_izvjestaj_masked_box.Text == "")
                return false;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.IzvjestajDAO c = d.getDAO.getIzvjestajDAO();

            try
            {
                c.getById(Convert.ToInt32(id_izvjestaj_masked_box.Text));
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
                    d.terminirajKonekciju();
                    return false;
                }
                d.terminirajKonekciju();
                return true;
            }
            else return false;
        }
        private void izvjestajID_masked_box_Leave(object sender, EventArgs e)
        {
            if (imaIzvjestaja())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.IzvjestajDAO c = d.getDAO.getIzvjestajDAO();

                Izvjestaj Izvjestaj = c.getById(Convert.ToInt32(id_izvjestaj_masked_box.Text));
                String datumIzvjestaja = Convert.ToString(Izvjestaj.DatumIzvjestaja);
                id_uposlenik_masked_box.Text = Convert.ToString(Izvjestaj.IDuposlenik);
                izvjestaj_datetime.Value = DateTime.Parse(datumIzvjestaja);
                sadrzaj_rich_box.Text = Izvjestaj.SadrzajIzvjestaja;
                d.terminirajKonekciju();
            }
            else
                MessageBox.Show("Unesi ispravan ID!");
        }
        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
