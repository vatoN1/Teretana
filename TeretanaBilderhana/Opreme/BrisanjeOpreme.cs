using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana.Opreme
{
    public partial class BrisanjeOpreme : Form
    {
        public BrisanjeOpreme()
        {
            InitializeComponent();
        }

        public bool imaOpreme()
        {
            if (opremaID_masked_box.Text == "")
                return false;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.OpremaDAO c = d.getDAO.getOpremaDAO();

            try
            {
                c.getById(Convert.ToInt32(opremaID_masked_box.Text));
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


        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void opremaID_masked_box_Leave(object sender, EventArgs e)
        {
            if (imaOpreme())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.OpremaDAO c = d.getDAO.getOpremaDAO();

                Oprema Oprema = c.getById(Convert.ToInt32(opremaID_masked_box.Text));
                kolicina_numeric.Value = Oprema.Kolicina;
                cijena_numeric.Value = Oprema.CijenaNajama;
                tipopremecombo.Text = Oprema.TipOpremeS;
                d.terminirajKonekciju();
            }
            else
                MessageBox.Show("Unesi ispravan ID!");
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.OpremaDAO c = d.getDAO.getOpremaDAO();
            Oprema o = c.getById(Convert.ToInt32(opremaID_masked_box.Text));
            c.delete(o);

            cijena_numeric.Value = cijena_numeric.Minimum;
            kolicina_numeric.Value = kolicina_numeric.Minimum;
            tipopremecombo.SelectedValue = "";
        }
    }
}
