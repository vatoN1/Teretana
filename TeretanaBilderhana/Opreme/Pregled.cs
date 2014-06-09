using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana.Opreme
{
    public partial class Pregled : Form
    {
        List<Oprema> opreme; 
        public Pregled()
        {
            InitializeComponent();
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.OpremaDAO c = d.getDAO.getOpremaDAO();
            opreme = c.GetAll();
            d.terminirajKonekciju();

            opremaPregledGrid.DataSource = opreme;
        }

        private void pretragaEvent(object sender, EventArgs e)
        {
            List<Oprema> pretrazeni = new List<Oprema>();
            foreach (Oprema o in opreme)
            {
                if (o.IdOpreme.ToString().Contains(pretragaTextBox.Text))
                    pretrazeni.Add(o);
            }

            opremaPregledGrid.DataSource = pretrazeni;

            if (pretragaTextBox.Text == "")
                opremaPregledGrid.DataSource = opreme;
        }
    }
}
