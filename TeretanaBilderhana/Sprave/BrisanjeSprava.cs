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
    public partial class BrisanjeSprava : Form
    {
        public BrisanjeSprava()
        {
            InitializeComponent();
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public bool imaSprava()
        {
            if (spravaID_masked_box.Text == "")
                return false;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.SpravaDAO c = d.getDAO.getSpravaDAO();

            try
            {
                c.getById(Convert.ToInt32(spravaID_masked_box.Text));
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
      

        private void spravaID_masked_box_Leave(object sender, EventArgs e)
        {
            if (imaSprava())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.SpravaDAO c = d.getDAO.getSpravaDAO();
                
                Sprava Sprava = c.getById(Convert.ToInt32(spravaID_masked_box.Text));
                kolicina_numeric.Value = Sprava.Kolicina;
                starost_numeric.Value = Sprava.Starost;
                tipsprave_combo.Text = Sprava.TipSpraveS;
                d.terminirajKonekciju();
            }
            else
                MessageBox.Show("Unesi ispravan ID!");
      
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.SpravaDAO c = d.getDAO.getSpravaDAO();
            Sprava Sprava = c.getById(Convert.ToInt32(spravaID_masked_box.Text));
            c.delete(Sprava);
            
            kolicina_numeric.Value = kolicina_numeric.Minimum;
            starost_numeric.Value = starost_numeric.Minimum;
            tipsprave_combo.Text = "";

            d.terminirajKonekciju();
            
        }
    }
}
