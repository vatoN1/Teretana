using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana.Prehrambeni_programi
{
    public partial class Pregled : Form
    {
        List<PrehrambeniProgram> pprogrami;
        public Pregled()
        {
            InitializeComponent();
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.PrehrambeniProgramDAO c = d.getDAO.getPrehrambeniProgramDAO();
            pprogrami = c.GetAll();
            d.terminirajKonekciju();

            pregledPProgramGrid.DataSource = pprogrami;
        }

        private void pretragaEvent(object sender, EventArgs e)
        {
            List<PrehrambeniProgram> pretrazeni = new List<PrehrambeniProgram>();
            foreach (PrehrambeniProgram pp in pprogrami)
            {
                if (pp.IdPrehrambeniProgram.ToString().Contains(pretragaTextBox.Text) || pp.TipProgramaS.Contains(pretragaTextBox.Text))
                    pretrazeni.Add(pp);
            }

            pregledPProgramGrid.DataSource = pretrazeni;

            if (pretragaTextBox.Text == "")
                pregledPProgramGrid.DataSource = pprogrami;
        }
    }
}
