using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana.Sprave
{
    public partial class Pregled : Form
    {
        List<Sprava> sprave;
        public Pregled()
        {
            InitializeComponent();
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.SpravaDAO c = d.getDAO.getSpravaDAO();
            sprave = c.GetAll();
            d.terminirajKonekciju();

            pregledSpraveGrid.DataSource = sprave;
        }

        private void pretragaEvent(object sender, EventArgs e)
        {
            List<Sprava> pretrazeni = new List<Sprava>();
            foreach (Sprava s in sprave)
            {
                if (s.Id.ToString().Contains(pretragaTextBox.Text) || s.TipSpraveS.Contains(pretragaTextBox.Text))
                    pretrazeni.Add(s);
            }

            pregledSpraveGrid.DataSource = pretrazeni;

            if (pretragaTextBox.Text == "")
                pregledSpraveGrid.DataSource = sprave;
        }
    }
}
