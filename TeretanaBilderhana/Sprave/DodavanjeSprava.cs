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
    public partial class DodavanjeSprava : Form
    {
        public DodavanjeSprava()
        {
            InitializeComponent();
            tipsprave_combo.Items.Add("WeightLifting Sprave");
            tipsprave_combo.Items.Add("Kardio Sprave");
            tipsprave_combo.Items.Add("Sto Za Masazu");
        }
        public bool validiraj() { return (errorProvider1.GetError(tipsprave_combo) == ""); }
        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                Random id = new Random();
                int r = id.Next(1111, 9999);
                Sprava Sprava = new Sprava(r, tipsprave_combo.Text, 
                    Convert.ToInt32(starost_numeric.Value), Convert.ToInt32(kolicina_numeric.Value));

                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.SpravaDAO c = d.getDAO.getSpravaDAO();

                Sprava.Id = (int)c.create(Sprava);
                d.terminirajKonekciju();
                MessageBox.Show("Sprava unesena! ID je: " + r);
                Close();
            }
        }
        private void tipsprave_Validating(object sender, CancelEventArgs e)
        {
            if (tipsprave_combo.SelectedItem == null)
            {
                errorProvider1.SetError(tipsprave_combo, "Odaberite tip workout programa!");
                toolStripStatusLabel1.Text = "Odaberite tip workout programa!!";
            }
            else
            {
                errorProvider1.SetError(tipsprave_combo, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
