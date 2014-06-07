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
    public partial class EditovanjeOpreme : Form
    {
        public EditovanjeOpreme()
        {
            InitializeComponent();
            tipopremecombo.Items.Add("Bandaze");
            tipopremecombo.Items.Add("Flasa");
            tipopremecombo.Items.Add("Peskir");
            tipopremecombo.Items.Add("Pojas");
            tipopremecombo.Items.Add("Rukavice");
            tipopremecombo.Items.Add("Sorts");
            tipopremecombo.Items.Add("Tene");
        }
        public bool validiraj()
        {
            return
            (
                (errorProvider1.GetError(tipopremecombo) == "") &&
                (errorProvider1.GetError(opremaID_masked_box)=="")  
            );
        }
        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.OpremaDAO c = d.getDAO.getOpremaDAO();

                Oprema Oprema = c.getById(Convert.ToInt32(opremaID_masked_box.Text));
                Oprema.Kolicina = Convert.ToInt32(kolicina_numeric.Value);
                Oprema.CijenaNajama = cijena_numeric.Value;
                Oprema.TipOpremeS = tipopremecombo.Text;

                c.update(Oprema);
                d.terminirajKonekciju();
                Close();
            }
        }
        private void opremaID_Validating(object sender, CancelEventArgs e)
        {
            if (opremaID_masked_box.Text.Length != 4)
            {
                errorProvider1.SetError(opremaID_masked_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(opremaID_masked_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void tipopreme_Validating(object sender, CancelEventArgs e)
        {
            if (tipopremecombo.SelectedItem == null)
            {
                errorProvider1.SetError(tipopremecombo, "Odaberite tip opreme!");
                toolStripStatusLabel1.Text = "Odaberite tip opreme!";
            }
            else
            {
                errorProvider1.SetError(tipopremecombo, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        public bool imaOpreme()
        {
            if (opremaID_masked_box.Text == "")
                return false;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.OpremaDAO c = d.getDAO.getOpremaDAO();

            try
            {
                c.getById(Convert.ToInt32(opremaID_masked_box.Text));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }

            d.terminirajKonekciju();
            return true;
        }
        private void opremaID_masked_box_Leave(object sender, EventArgs e)
        {
            if (imaOpreme())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.OpremaDAO c = d.getDAO.getOpremaDAO();

                Oprema Oprema = c.getById(Convert.ToInt32(opremaID_masked_box.Text));
                kolicina_numeric.Value = Oprema.Kolicina;
                cijena_numeric.Value = Oprema.CijenaNajama;
                tipopremecombo.Text = Oprema.TipOpremeS;
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
