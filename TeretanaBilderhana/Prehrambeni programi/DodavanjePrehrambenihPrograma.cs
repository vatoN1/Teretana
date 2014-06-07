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
    public partial class DodavanjePrehrambenihPrograma : Form
    {
        public DodavanjePrehrambenihPrograma()
        {
            InitializeComponent();
            tipprehrambenog_combo.Items.Add("Licni Program");
            tipprehrambenog_combo.Items.Add("Tipicni Program");
        }
        public bool validiraj()
        {
            return
            (
                (errorProvider1.GetError(tipprehrambenog_combo) == "") &&
                (errorProvider1.GetError(opis_pprogram_rich_box) == "") &&
                (errorProvider1.GetError(obroci_pprogram_rich_box) == "")
            );
        }
        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                Random id = new Random();
                int r = id.Next(1111, 9999);
                PrehrambeniProgram PrehrambeniProgram = new PrehrambeniProgram(
                       r, opis_pprogram_rich_box.Text, "Licni Program", obroci_pprogram_rich_box.Text);
                if (tipprehrambenog_combo.Text == "Tipicni Program")
                    PrehrambeniProgram.TipProgramaS = "Tipicni Program";

                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.PrehrambeniProgramDAO c = d.getDAO.getPrehrambeniProgramDAO();

                PrehrambeniProgram.IdPrehrambeniProgram = (int)c.create(PrehrambeniProgram);
                d.terminirajKonekciju();
                MessageBox.Show("Prehrambeni program unesen! ID je: " + r);
                Close();
            }
        }
        private void opis_pprogram_rich_box_Validating(object sender, CancelEventArgs e)
        {
            if (opis_pprogram_rich_box.Text.Length < 10)
            {
                errorProvider1.SetError(opis_pprogram_rich_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Sadrzaj opisa programa treba da sadrzava makar 10 karaktera!";
            }
            else
            {
                errorProvider1.SetError(opis_pprogram_rich_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void obroci_pprogram_rich_box_Validating(object sender, CancelEventArgs e)
        {
            if (obroci_pprogram_rich_box.Text.Length < 10)
            {
                errorProvider1.SetError(obroci_pprogram_rich_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Obroci treba da sadrze makar 10 karaktera!";
            }
            else
            {
                errorProvider1.SetError(obroci_pprogram_rich_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void tipprehrambenog_combo_Validating(object sender, CancelEventArgs e)
        {
            if (tipprehrambenog_combo.SelectedItem == null)
            {
                errorProvider1.SetError(tipprehrambenog_combo, "Odaberite tip workout programa!");
                toolStripStatusLabel1.Text = "Odaberite tip workout programa!!";
            }
            else
            {
                errorProvider1.SetError(tipprehrambenog_combo, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
