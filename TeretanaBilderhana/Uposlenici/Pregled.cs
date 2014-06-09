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

namespace TeretanaBilderhana.Uposlenici
{
    public partial class Pregled : Form
    {
        List<Uposlenik> uposlenici;
        public Pregled()
        {
            InitializeComponent();
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();
            uposlenici = c.GetAll();
            d.terminirajKonekciju();

            uposleniciPregledGrid.DataSource = uposlenici;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void pretragaTextChanged(object sender, EventArgs e)
        {
            List<Uposlenik> pretrazeni = new List<Uposlenik>();
            foreach (Uposlenik u in uposlenici)
            {
                if (u.Ime.Contains(pretragaTextBox.Text) || u.Prezime.Contains(pretragaTextBox.Text)
                    || u.ID.ToString().Contains(pretragaTextBox.Text))
                    pretrazeni.Add(u);
            }

            uposleniciPregledGrid.DataSource = pretrazeni;

            if (pretragaTextBox.Text == "")
                uposleniciPregledGrid.DataSource = uposlenici;
        }
    }
}
