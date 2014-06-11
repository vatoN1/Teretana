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
    public partial class EditovanjePrehrambenihPrograma : Form
    {
        public EditovanjePrehrambenihPrograma()
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
                (errorProvider1.GetError(obroci_pprogram_rich_box) == "") &&
                (errorProvider1.GetError(pprogram_masked_box)=="")
            );
        }
        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.PrehrambeniProgramDAO c = d.getDAO.getPrehrambeniProgramDAO();

                PrehrambeniProgram PrehrambeniProgram = c.getById(Convert.ToInt32(pprogram_masked_box.Text));
                PrehrambeniProgram.TipProgramaS = tipprehrambenog_combo.Text;
                PrehrambeniProgram.Opis = opis_pprogram_rich_box.Text;
                PrehrambeniProgram.Obroci = obroci_pprogram_rich_box.Text;

                c.update(PrehrambeniProgram);
                d.terminirajKonekciju();
                Close();
            }
        }
        private void pprogramID_Validating(object sender, CancelEventArgs e)
        {
            if (pprogram_masked_box.Text.Length != 4)
            {
                errorProvider1.SetError(pprogram_masked_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(pprogram_masked_box, "");
                toolStripStatusLabel1.Text = "";
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
        public bool imaPrograma()
        {
            if (pprogram_masked_box.Text == "")
                return false;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.PrehrambeniProgramDAO c = d.getDAO.getPrehrambeniProgramDAO();

            try
            {
                c.getById(Convert.ToInt32(pprogram_masked_box.Text));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                d.terminirajKonekciju();
                return false;
            }

            d.terminirajKonekciju();
            return true;
        }
        private void pprogram_masked_box_Leave(object sender, EventArgs e)
        {
            if (imaPrograma())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.PrehrambeniProgramDAO c = d.getDAO.getPrehrambeniProgramDAO();

                PrehrambeniProgram PrehrambeniProgram = c.getById(Convert.ToInt32(pprogram_masked_box.Text));
                tipprehrambenog_combo.SelectedText = PrehrambeniProgram.TipProgramaS;
                opis_pprogram_rich_box.Text = PrehrambeniProgram.Opis;
                obroci_pprogram_rich_box.Text = PrehrambeniProgram.Obroci;
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
