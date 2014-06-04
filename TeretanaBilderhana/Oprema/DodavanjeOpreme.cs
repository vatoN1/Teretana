using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace TeretanaBilderhana.Oprema
{
    public partial class DodavanjeOpreme : Form
    {
        public DodavanjeOpreme()
        {
            InitializeComponent();
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
//                Inventar o = new Inventar(
  //                  r, Convert.ToInt32(kolicina_numeric.Value), Convert.ToDouble(cijena_numeric.Value), tipopremecombo.Text);

                DAL.DAL d = DAL.DAL.Instanca;

                d.kreirajKonekciju("localhost", "Teretana", "root", "");

                DAL.DAL.IzvjestajDAO c = d.getDAO.getIzvjestajDAO();
    //            o.ID = (int)c.create(o);
                d.terminirajKonekciju();
                MessageBox.Show("Izvjestaj unesen! ID je: " + r);
                Close();
            }

        }
    }
}
