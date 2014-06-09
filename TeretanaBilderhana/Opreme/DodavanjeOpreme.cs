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
    public partial class DodavanjeOpreme : Form
    {
        public DodavanjeOpreme()
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
                (errorProvider1.GetError(tipopremecombo) == "")
            );
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj())
            {
                Random id = new Random();
                int r = id.Next(1111, 9999); 
                Oprema Oprema = new Oprema(r, Convert.ToInt32(kolicina_numeric.Value), cijena_numeric.Value, 
                    tipopremecombo.Text);

                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.OpremaDAO c = d.getDAO.getOpremaDAO();

                Oprema.IdOpreme = (int)c.create(Oprema);
                d.terminirajKonekciju();
                MessageBox.Show("Oprema unesena! ID je: " + r);
                Close();
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
        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
