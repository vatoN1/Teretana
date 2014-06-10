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
    public partial class BrisanjeIzvjestaja : Form
    {
        public BrisanjeIzvjestaja()
        {
            InitializeComponent();
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.IzvjestajDAO c = d.getDAO.getIzvjestajDAO();
            Izvjestaj Izvjestaj = c.getById(Convert.ToInt32(id_izvjestaj_masked_box.Text));
            c.delete(Izvjestaj);

            id_uposlenik_masked_box.Text = "";
            izvjestaj_datetime.Value = DateTime.Now;
            sadrzaj_rich_box.Text = "";
            d.terminirajKonekciju();
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
                d.terminirajKonekciju();
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }

            d.terminirajKonekciju();
            return true;
        }

        private void id_izvjestaj_masked_box_Leave(object sender, EventArgs e)
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
    }
}
