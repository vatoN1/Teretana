using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana.Izvjestaji
{
    public partial class Pregled : Form
    {
        List<Izvjestaj> izvjestaji;
        public Pregled()
        {
            InitializeComponent();
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.IzvjestajDAO c = d.getDAO.getIzvjestajDAO();
            izvjestaji = c.GetAll();
            d.terminirajKonekciju();

            pregledIzvjestajGrid.DataSource = izvjestaji;
        }

        private void pretragaEvent(object sender, EventArgs e)
        {
            List<Izvjestaj > pretrazeni = new List<Izvjestaj>();
            foreach (Izvjestaj i in izvjestaji)
            {
                if (i.IdIzvjestaja.ToString().Contains(pretragaTextBox.Text) || i.IDuposlenik.ToString().Contains(pretragaTextBox.Text))
                    pretrazeni.Add(i);
            }

            pregledIzvjestajGrid.DataSource = pretrazeni;

            if (pretragaTextBox.Text == "")
                pregledIzvjestajGrid.DataSource = izvjestaji;
        }

    }
}
