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
    public partial class EditovanjeProstorija : Form
    {
        public EditovanjeProstorija()
        {
            InitializeComponent();
            prostorijacombo.Items.Add("Kardio Soba");
            prostorijacombo.Items.Add("Magacin");
            prostorijacombo.Items.Add("Milkbar");
            prostorijacombo.Items.Add("Soba Za Masazu");
            prostorijacombo.Items.Add("Svlacionica");
            prostorijacombo.Items.Add("WeightLifting Soba");
        }
        public bool validiraj()
        {
            return
            (
                (errorProvider1.GetError(prostorijacombo) == "") &&
                (errorProvider1.GetError(groupBox2) == "") &&
                (errorProvider1.GetError(inventar_rich_box) == "") &&
                (errorProvider1.GetError(prostorijaID_masked_box)=="") 
            );
        }
        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.ProstorijaDAO c = d.getDAO.getProstorijaDAO();

                Prostorija Prostorija = c.getById(Convert.ToInt32(prostorijaID_masked_box.Text));
                Prostorija.TipProstorije = prostorijacombo.Text;
                if (dostupna_NE.Checked == true) Prostorija.Dostupnost = "NE";
                else Prostorija.Dostupnost = "DA";
                Prostorija.Inventar1 = inventar_rich_box.Text;

                c.update(Prostorija);
                d.terminirajKonekciju();
                Close();
            }
        }
        private void prostorijaID_Validating(object sender, CancelEventArgs e)
        {
            if (prostorijaID_masked_box.Text.Length != 4)
            {
                errorProvider1.SetError(prostorijaID_masked_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(prostorijaID_masked_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void Dostupnost_Validating(object sender, CancelEventArgs e)
        {
            if (dostupna_DA.Checked == false && dostupna_NE.Checked == false)
            {
                errorProvider1.SetError(groupBox2, "Odaberite dostupnost!");
                toolStripStatusLabel1.Text = "Odaberite dostupnost!";
            }
            else
            {
                errorProvider1.SetError(groupBox2, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void prostorijacombo_Validating(object sender, CancelEventArgs e)
        {
            if (prostorijacombo.SelectedItem == null)
            {
                errorProvider1.SetError(prostorijacombo, "Odaberite prostoriju!");
                toolStripStatusLabel1.Text = "Odaberite prostoriju!";
            }
            else
            {
                errorProvider1.SetError(prostorijacombo, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void inventar_rich_box_Validating(object sender, CancelEventArgs e)
        {
            if (inventar_rich_box.Text.Length < 10)
            {
                errorProvider1.SetError(inventar_rich_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Inventar treba da sadrzava makar 10 karaktera!";
            }
            else
            {
                errorProvider1.SetError(inventar_rich_box, "");
                toolStripStatusLabel1.Text = "";
            }
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
                MessageBox.Show(Convert.ToString(ex));
                d.terminirajKonekciju();
                return false;
            }

            d.terminirajKonekciju();
            return true;
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
        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
