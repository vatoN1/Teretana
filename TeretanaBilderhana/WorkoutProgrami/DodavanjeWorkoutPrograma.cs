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
    public partial class DodavanjeWorkoutPrograma : Form
    {
        public DodavanjeWorkoutPrograma()
        {
            InitializeComponent();
            tipwp_combo.Items.Add("Licni Program");
            tipwp_combo.Items.Add("Tipicni Program");
        }
        public bool validiraj()
        {
            return
            (
                (errorProvider1.GetError(tipwp_combo) == "") &&
                (errorProvider1.GetError(opis_wprogram_rich_box) == "") &&
                (errorProvider1.GetError(vjezbe_rich_box) == "")
            );
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                Random id = new Random();
                int r = id.Next(1111, 9999);
                WorkoutProgram WorkoutProgram = new WorkoutProgram(
                       r, opis_wprogram_rich_box.Text, "Licni Program", vjezbe_rich_box.Text);
                if (tipwp_combo.Text == "Tipicni Program")
                    WorkoutProgram.TipProgramaS = "Tipicni Program";
                
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.WorkoutProgramDAO c = d.getDAO.getWorkoutProgramDAO();
              
                WorkoutProgram.IdWorkoutPrograma = (int)c.create(WorkoutProgram);
                d.terminirajKonekciju();
                MessageBox.Show("Workout program unesen! ID je: " + r);
                Close();
            }
        }
        private void vjezbe_rich_box_Validating(object sender, CancelEventArgs e)
        {
            if (vjezbe_rich_box.Text.Length < 10)
            {
                errorProvider1.SetError(vjezbe_rich_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Sadrzaj vjezbi treba da sadrzava makar 10 karaktera!";
            }
            else
            {
                errorProvider1.SetError(vjezbe_rich_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void opis_wprogram_rich_box_Validating(object sender, CancelEventArgs e)
        {
            if (opis_wprogram_rich_box.Text.Length < 10)
            {
                errorProvider1.SetError(opis_wprogram_rich_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Opis treba da sadrzava makar 10 karaktera!";
            }
            else
            {
                errorProvider1.SetError(opis_wprogram_rich_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void tipwp_Validating(object sender, CancelEventArgs e)
        {
            if (tipwp_combo.SelectedItem == null)
            {
                errorProvider1.SetError(tipwp_combo, "Odaberite tip workout programa!");
                toolStripStatusLabel1.Text = "Odaberite tip workout programa!!";
            }
            else
            {
                errorProvider1.SetError(tipwp_combo, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
