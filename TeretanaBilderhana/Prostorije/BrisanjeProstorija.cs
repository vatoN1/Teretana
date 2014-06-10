using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana.Prostorije
{
    public partial class BrisanjeProstorija : Form
    {
        public BrisanjeProstorija()
        {
            InitializeComponent();
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public bool imaProstorije()
        {
            if (prostorijaID_masked_box.Text == "")
                return false;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.ProstorijaDAO c = d.getDAO.getProstorijaDAO();

            try
            {
                c.getById(Convert.ToInt32(prostorijaID_masked_box.Text));
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

        private void unosButton_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.ProstorijaDAO c = d.getDAO.getProstorijaDAO();
            Prostorija Prostorija = c.getById(Convert.ToInt32(prostorijaID_masked_box.Text));
            c.delete(Prostorija);
            
            prostorijacombo.SelectedText = "";
            dostupna_DA.Checked = true;
            dostupna_NE.Checked = false;
            inventar_rich_box.Text = "";
            d.terminirajKonekciju();
            
        }

        private void prostorijaID_masked_box_Leave(object sender, EventArgs e)
        {
            if (imaProstorije())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.ProstorijaDAO c = d.getDAO.getProstorijaDAO();

                Prostorija Prostorija = c.getById(Convert.ToInt32(prostorijaID_masked_box.Text));
                prostorijacombo.SelectedText = Prostorija.TipProstorije;
                if (Prostorija.Dostupnost == "DA") dostupna_DA.Checked = true;
                else dostupna_NE.Checked = true;
                inventar_rich_box.Text = Prostorija.Inventar1;
                d.terminirajKonekciju();
            }
            else
                MessageBox.Show("Unesi ispravan ID!");

        }
    }
}
