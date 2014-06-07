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
    public partial class EditovanjeWorkoutPrograma : Form
    {
        public EditovanjeWorkoutPrograma()
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
                (errorProvider1.GetError(vjezbe_rich_box) == "") &&
                (errorProvider1.GetError(wprogramID_masked_box)=="")
            );
        }
        private void wprogramID_Validating(object sender, CancelEventArgs e)
        {
            if (wprogramID_masked_box.Text.Length != 4)
            {
                errorProvider1.SetError(wprogramID_masked_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(wprogramID_masked_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.WorkoutProgramDAO c = d.getDAO.getWorkoutProgramDAO();

                WorkoutProgram WorkoutProgram = c.getById(Convert.ToInt32(wprogramID_masked_box.Text));
                WorkoutProgram.TipProgramaS = tipwp_combo.Text;
                WorkoutProgram.Opis = opis_wprogram_rich_box.Text;
                WorkoutProgram.Vjezbe = vjezbe_rich_box.Text;

                c.update(WorkoutProgram);
                d.terminirajKonekciju();
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
        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
