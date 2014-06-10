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
    public partial class BrisanjeWorkoutPrograma : Form
    {
        public BrisanjeWorkoutPrograma()
        {
            InitializeComponent();
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.WorkoutProgramDAO c = d.getDAO.getWorkoutProgramDAO();
            WorkoutProgram WorkoutProgram = c.getById(Convert.ToInt32(wprogramID_masked_box.Text));
            c.delete(WorkoutProgram);

            tipwp_combo.SelectedText = "";
            opis_wprogram_rich_box.Text = "";
            vjezbe_rich_box.Text = "";
            d.terminirajKonekciju();

        }

        public bool imaPrograma()
        {
            if (wprogramID_masked_box.Text == "")
                return false;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.WorkoutProgramDAO c = d.getDAO.getWorkoutProgramDAO();

            try
            {
                c.getById(Convert.ToInt32(wprogramID_masked_box.Text));
            }
            catch (System.Exception ex)
            {
                d.terminirajKonekciju();
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }

            d.terminirajKonekciju();
            return true;
        }
 

        private void wprogramID_masked_box_Leave(object sender, EventArgs e)
        {
            if (imaPrograma())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.WorkoutProgramDAO c = d.getDAO.getWorkoutProgramDAO();

                WorkoutProgram WorkoutProgram = c.getById(Convert.ToInt32(wprogramID_masked_box.Text));
                tipwp_combo.SelectedText = WorkoutProgram.TipProgramaS;
                opis_wprogram_rich_box.Text = WorkoutProgram.Opis;
                vjezbe_rich_box.Text = WorkoutProgram.Vjezbe;
                d.terminirajKonekciju();
            }
            else
                MessageBox.Show("Unesi ispravan ID!");
        }
    }
}
