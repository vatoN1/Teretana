using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana.WorkoutProgrami
{
    public partial class Pregled : Form
    {
        List<WorkoutProgram> wprogrami;
        public Pregled()
        {
            InitializeComponent();
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.WorkoutProgramDAO c = d.getDAO.getWorkoutProgramDAO();
            wprogrami = c.GetAll();
            d.terminirajKonekciju();

            pregledWProgramGrid.DataSource = wprogrami;
        }

        private void pretragaEvent(object sender, EventArgs e)
        {
            List<WorkoutProgram> pretrazeni = new List<WorkoutProgram>();
            foreach (WorkoutProgram wp in wprogrami)
            {
                if (wp.IdWorkoutPrograma.ToString().Contains(pregledTextBox.Text))
                    pretrazeni.Add(wp);
            }

            pregledWProgramGrid.DataSource = pretrazeni;

            if (pregledTextBox.Text == "")
                pregledWProgramGrid.DataSource = wprogrami;
        }
    }
}
