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
    public partial class DodavanjeProstorija : Form
    {
        public DodavanjeProstorija()
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
                (errorProvider1.GetError(inventar_rich_box) == "")
            );
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                String Dostupnost = "DA";
                Random id = new Random();
                int r = id.Next(1111, 9999);
                if (dostupna_NE.Checked) Dostupnost = "NE";
                Prostorija Prostorija = new Prostorija(
                    r, Dostupnost, prostorijacombo.Text, inventar_rich_box.Text);

                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.ProstorijaDAO c = d.getDAO.getProstorijaDAO();
                Prostorija.Id = (int)c.create(Prostorija);
                d.terminirajKonekciju();
                MessageBox.Show("Prostorija unesena! ID je: " + r);
                Close();
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
        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
