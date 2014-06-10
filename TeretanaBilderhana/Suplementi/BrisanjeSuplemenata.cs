using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana.Suplementi
{
    public partial class BrisanjeSuplemenata : Form
    {
        public BrisanjeSuplemenata()
        {
            InitializeComponent();
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool imaSuplementa()
        {
            if (suplementID_masked_box.Text == "")
                return false;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.SuplementDAO c = d.getDAO.getSuplementDAO();

            try
            {
                c.getById(Convert.ToInt32(suplementID_masked_box.Text));
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

        private void suplementID_masked_box_Leave(object sender, EventArgs e)
        {
            if (imaSuplementa())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.SuplementDAO c = d.getDAO.getSuplementDAO();

                Suplement Suplement = c.getById(Convert.ToInt32(suplementID_masked_box.Text));
                kolicina_numeric.Value = Suplement.Kolicina;
                cijena_numeric.Value = Suplement.Cijena;
                tipsuplementa_combo.Text = Suplement.TipSuplementaS;
                d.terminirajKonekciju();
            }
            else
                MessageBox.Show("Unesi ispravan ID!");
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.SuplementDAO c = d.getDAO.getSuplementDAO();
            Suplement Suplement = c.getById(Convert.ToInt32(suplementID_masked_box.Text));
            c.delete(Suplement);
            
            kolicina_numeric.Value = kolicina_numeric.Minimum;
            cijena_numeric.Value = cijena_numeric.Minimum;
            tipsuplementa_combo.Text = "";
            d.terminirajKonekciju();
            
        }
    }
}
