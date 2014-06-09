using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace TeretanaBilderhana.Klijenti
{
    public partial class Pregled : Form
    {
        List<Klijent> klijenti;
        public Pregled()
        {
            InitializeComponent();
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.KlijentDAO c = d.getDAO.getKlijentDAO();
            klijenti = c.GetAll();
            d.terminirajKonekciju();
            klijentiPregledGrid.DataSource = klijenti;
        }

        private void pretragaEvent(object sender, EventArgs e)
        {
            List<Klijent> pretrazeni = new List<Klijent>();
            foreach (Klijent k in klijenti)
            {
                if (k.Ime.Contains(pretragaTextBox.Text) || k.Prezime.Contains(pretragaTextBox.Text)
                    || k.ID.ToString().Contains(pretragaTextBox.Text))
                    pretrazeni.Add(k);
            }

            klijentiPregledGrid.DataSource = pretrazeni;

            if (pretragaTextBox.Text == "")
                klijentiPregledGrid.DataSource = klijenti;
        }
    }
}
