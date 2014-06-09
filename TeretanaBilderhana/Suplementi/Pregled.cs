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
    public partial class Pregled : Form
    {
        List<Suplement> suplementi;
        public Pregled()
        {
            InitializeComponent();
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.SuplementDAO c = d.getDAO.getSuplementDAO();
            suplementi = c.GetAll();
            d.terminirajKonekciju();

            pregledSuplementiGrid.DataSource = suplementi;
        }

        private void pretragaEvent(object sender, EventArgs e)
        {
            List<Suplement> pretrazeni = new List<Suplement>();
            foreach (Suplement s in suplementi)
            {
                if (s.IdSuplementa.ToString().Contains(pretragaTextBox.Text) || s.TipSuplementaS.Contains(pretragaTextBox.Text))
                    pretrazeni.Add(s);
            }

            pregledSuplementiGrid.DataSource = pretrazeni;

            if (pretragaTextBox.Text == "")
                pregledSuplementiGrid.DataSource = suplementi;
        }
    }
}
