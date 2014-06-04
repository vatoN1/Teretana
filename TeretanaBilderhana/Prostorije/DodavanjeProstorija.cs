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
                bool Dostupnost = true;
                Random id = new Random();
                int r = id.Next(1111, 9999);
                if (dostupna_NE.Checked) Dostupnost = false;
                Prostorija p = new Prostorija(
                    r, prostorijacombo.Text, Dostupnost, inventar_rich_box.Text);

                DAL.DAL d = DAL.DAL.Instanca;

                d.kreirajKonekciju("localhost", "Teretana", "root", "");

                DAL.DAL.ProstorijaDAO c = d.getDAO.getProstorijaDAO();

                p.Id = (int)c.create(p);
                d.terminirajKonekciju();
                MessageBox.Show("Klijent unesen! ID je: " + r);
                Close();
            }
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
