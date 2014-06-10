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
    public partial class BrisanjeUposlenika : Form
    {
        public BrisanjeUposlenika()
        {
            InitializeComponent();
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ima()
        {
            if (uposlenikID_masked_box.Text == "")
                return false;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

            try
            {
                c.getById(Convert.ToInt32(uposlenikID_masked_box.Text));
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

        private void uposlenikID_masked_box_Leave(object sender, EventArgs e)
        {
            if (ima())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

                Uposlenik Uposlenik = c.getById(Convert.ToInt32(uposlenikID_masked_box.Text));
                string rodjenje = Convert.ToString(Uposlenik.DatumRodjenja);
                string zaposlenje = Convert.ToString(Uposlenik.DatumZaposlenja);
                imetb.Text = Uposlenik.Ime;
                prezimetb.Text = Uposlenik.Prezime;
                if (Convert.ToString(Uposlenik.Spol) == "Musko") muskoRB.Checked = true;
                else zenskoRB.Checked = true;
                rodjenje_datetime.Value = DateTime.Parse(rodjenje);
                kontakt_masked_box.Text = Uposlenik.Kontakt;
                plata_npd.Value = Uposlenik.Plata;
                zaposlenje_datetime.Value = DateTime.Parse(zaposlenje);
                zaposlenje_combo.SelectedText = Uposlenik.ZaposlenjeS;
                sifra_box.Text = Uposlenik.Sifra;
                d.terminirajKonekciju();
            }
            else
                MessageBox.Show("Unesi ispravan ID!");
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            try
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();
                Uposlenik u = c.getById(Convert.ToUInt32(uposlenikID_masked_box.Text));
                c.delete(u);


                imetb.Text = "";
                prezimetb.Text = "";
                muskoRB.Checked = true;
                zenskoRB.Checked = false;
                rodjenje_datetime.Value = DateTime.Now;
                kontakt_masked_box.Text = "";
                plata_npd.Value = plata_npd.Minimum;
                zaposlenje_datetime.Value = DateTime.Now;
                zaposlenje_combo.SelectedText = "";
                sifra_box.Text = "";


                d.terminirajKonekciju();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ne mozete ukloniti tog uposlenika");
            }
            
        }

       
    }
}
