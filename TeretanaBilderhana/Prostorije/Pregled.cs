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
    public partial class Pregled : Form
    {
        List<Prostorija> prostorije;
        public Pregled()
        {
            InitializeComponent();
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.ProstorijaDAO c = d.getDAO.getProstorijaDAO();
            prostorije = c.GetAll();
            d.terminirajKonekciju();
        }

        private void pretragaEvent(object sender, EventArgs e)
        {
            List<Prostorija> pretrazeni = new List<Prostorija>();
            foreach (Prostorija p in prostorije)
            {
                if (p.Id.ToString().Contains(pretragaTextBox.Text) || p.TipProstorije.Contains(pretragaTextBox.Text))
                    pretrazeni.Add(p);
            }

            pregledProstorijeGrid.DataSource = pretrazeni;

            if (pretragaTextBox.Text == "")
                pregledProstorijeGrid.DataSource = prostorije;
        }
    }
}
