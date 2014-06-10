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
    public partial class BrisanjePrehrambenihPrograma : Form
    {
        public BrisanjePrehrambenihPrograma()
        {
            InitializeComponent();
        }

        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                d.terminirajKonekciju();
                MessageBox.Show(Convert.ToString(ex));
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

        private void unosButton_Click(object sender, EventArgs e)
        {
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.PrehrambeniProgramDAO c = d.getDAO.getPrehrambeniProgramDAO();
            PrehrambeniProgram PrehrambeniProgram = c.getById(Convert.ToInt32(pprogram_masked_box.Text));
            c.delete(PrehrambeniProgram);
            
            tipprehrambenog_combo.SelectedText = "";
            opis_pprogram_rich_box.Text = "";
            obroci_pprogram_rich_box.Text = "";
            d.terminirajKonekciju();
        }


    }
}
