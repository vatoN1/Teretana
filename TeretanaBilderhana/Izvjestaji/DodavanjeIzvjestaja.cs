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
            if (validiraj())
            {
                Random id = new Random();
                int r = id.Next(1111, 9999);
                Izvjestaj i = new Izvjestaj(
                    r, Convert.ToInt32(id_uposlenik_masked_box.Text), izvjestaj_datetime.Value , sadrzaj_rich_box.Text);

                DAL.DAL d = DAL.DAL.Instanca;

                d.kreirajKonekciju("localhost", "Teretana", "root", "");

                DAL.DAL.IzvjestajDAO c = d.getDAO.getIzvjestajDAO();

                i.ID = (int)c.create(i);
                d.terminirajKonekciju();
                MessageBox.Show("Izvjestaj unesen! ID je: " + r);
                Close();
            }
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
