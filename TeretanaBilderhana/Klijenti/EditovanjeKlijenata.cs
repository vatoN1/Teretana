﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeretanaBilderhana.Klijenti
{
    public partial class EditovanjeKlijenata : Form
    {
        List<Uposlenik> Uposlenici;
        public EditovanjeKlijenata()
        {
            InitializeComponent();
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();
            Uposlenici = c.GetAll();
            d.terminirajKonekciju();
            bodymass_numeric.Value = visina_numeric.Value - tezina_numeric.Value;
            foreach (Uposlenik u in Uposlenici)
            {
                if (u.ZaposlenjeS == "Trener") trener_combo.Items.Add(u);
                else if (u.ZaposlenjeS == "Nutricionista") nutricionista_combo.Items.Add(u);
            }
        }

        public bool validiraj()
        {
            return
            (
                (errorProvider1.GetError(imetb) == "") &&
                (errorProvider1.GetError(prezimetb) == "") &&
                (errorProvider1.GetError(kontakttb) == "") &&
                (errorProvider1.GetError(trenerID_masked_box) == "") &&
                (errorProvider1.GetError(nutricionistaID_masked_box) == "") &&
                (errorProvider1.GetError(groupBox2) == "") &&
                (errorProvider1.GetError(klijentID_masked_box)=="")
            );
        }

        private void unosButton_Click(object sender, EventArgs e)
        {
            if (validiraj() && imaNutricioniste() && imaTrenera())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.KlijentDAO c = d.getDAO.getKlijentDAO();

                Klijent Klijent = c.getById(Convert.ToInt32(klijentID_masked_box.Text));
                Klijent.Ime = imetb.Text;
                Klijent.Prezime = prezimetb.Text;
                if (muskoRB.Checked == true) Klijent.Spol = Spol.Musko;
                else Klijent.Spol = Spol.Zensko;
                Klijent.Kontakt = kontakttb.Text;
                Klijent.IDnutricioniste = Convert.ToInt32(nutricionistaID_masked_box.Text);
                Klijent.IDtrenera = Convert.ToInt32(trenerID_masked_box.Text);
                Klijent.Visina = Convert.ToInt32(visina_numeric.Value);
                Klijent.Tezina = tezina_numeric.Value;
                //MessageBox.Show(zaposlenje_combo.Text);
                c.update(Klijent);
                d.terminirajKonekciju();
                //Close();
            }
        }
        private void klijentID_Validating(object sender, CancelEventArgs e)
        {
            if (klijentID_masked_box.Text.Length != 4)
            {
                errorProvider1.SetError(klijentID_masked_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(klijentID_masked_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void imetb_Validating(object sender, CancelEventArgs e)
        {
            if (imetb.Text.Length < 3)
            {
                errorProvider1.SetError(imetb, "Ime prekratko");
                toolStripStatusLabel1.Text = "Ime prekratko!";
            }
            else
            {
                errorProvider1.SetError(imetb, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void prezimetb_Validating(object sender, CancelEventArgs e)
        {
            if (prezimetb.Text.Length < 3)
            {
                errorProvider1.SetError(prezimetb, "Prezime prekratko");
                toolStripStatusLabel1.Text = "Prezime prekratko!";
            }
            else
            {
                errorProvider1.SetError(prezimetb, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void kontakttb_Validating(object sender, CancelEventArgs e)
        {
            if (kontakttb.Text.Length != 9)
            {
                errorProvider1.SetError(kontakttb, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(kontakttb, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void Spol_Validating(object sender, CancelEventArgs e)
        {
            if (muskoRB.Checked == false && zenskoRB.Checked == false)
            {
                errorProvider1.SetError(groupBox2, "Odaberite spol!");
                toolStripStatusLabel1.Text = "Odaberite spol!";
            }
            else
            {
                errorProvider1.SetError(groupBox2, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void trenerID_Validating(object sender, CancelEventArgs e)
        {
            if (trenerID_masked_box.Text.Length != 4)
            {
                errorProvider1.SetError(trenerID_masked_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(trenerID_masked_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        private void nutricionistaID_Validating(object sender, CancelEventArgs e)
        {
            if (nutricionistaID_masked_box.Text.Length != 4)
            {
                errorProvider1.SetError(nutricionistaID_masked_box, "Nedovoljan broj karaktera!");
                toolStripStatusLabel1.Text = "Nedovoljan broj karaktera!";
            }
            else
            {
                errorProvider1.SetError(nutricionistaID_masked_box, "");
                toolStripStatusLabel1.Text = "";
            }
        }
        public bool imaKlijenta()
        {
            if (klijentID_masked_box.Text == "")
                return false;
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "Teretana", "root", "");
            DAL.DAL.KlijentDAO c = d.getDAO.getKlijentDAO();

            try
            {
                c.getById(Convert.ToInt32(klijentID_masked_box.Text));
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
        public bool imaTrenera()
        {
            if (trenerID_masked_box.Text.Length == 4)
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

                try
                {
                    Uposlenik radnik = c.getById(Convert.ToInt32(trenerID_masked_box.Text));
                    if (radnik.ZaposlenjeS == "Trener") 
                    {
                        d.terminirajKonekciju();
                        return true;
                    }
                    else
                    {
                        d.terminirajKonekciju();
                        return false;
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    d.terminirajKonekciju();
                    return false;
                }
            }
            else return false;
        }
        public bool imaNutricioniste()
        {
            if (nutricionistaID_masked_box.Text.Length == 4)
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.UposlenikDAO c = d.getDAO.getUposlenikDAO();

                try
                {
                    Uposlenik radnik = c.getById(Convert.ToInt32(nutricionistaID_masked_box.Text));
                    if (radnik.ZaposlenjeS == "Nutricionista")
                    {
                        d.terminirajKonekciju();
                        return true;
                    }
                    else
                    {
                        d.terminirajKonekciju();
                        return false;
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    d.terminirajKonekciju();
                    return false;
                }
            }
            else return false;
        }
        private void klijentID_masked_box_Leave(object sender, EventArgs e)
        {
            if (imaKlijenta())
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju("localhost", "Teretana", "root", "");
                DAL.DAL.KlijentDAO c = d.getDAO.getKlijentDAO();

                Klijent Klijent = c.getById(Convert.ToInt32(klijentID_masked_box.Text));
                string rodjenje = Convert.ToString(Klijent.DatumRodjenja);
                imetb.Text = Klijent.Ime;
                prezimetb.Text = Klijent.Prezime;
                if (Convert.ToString(Klijent.Spol) == "Musko") muskoRB.Checked = true;
                else zenskoRB.Checked = true;
                datumRodjenjadtp.Value = DateTime.Parse(rodjenje);
                kontakttb.Text = Klijent.Kontakt;
                visina_numeric.Value = Klijent.Visina;
                tezina_numeric.Value = Klijent.Tezina;
                if (Convert.ToString(Klijent.Spol) == "Musko")
                    bodymass_numeric.Value = Klijent.Visina - 100;
                else bodymass_numeric.Value = Klijent.Visina - 110;
                trenerID_masked_box.Text = Convert.ToString(Klijent.IDtrenera);
                nutricionistaID_masked_box.Text = Convert.ToString(Klijent.IDnutricioniste);
                d.terminirajKonekciju();
                toolStripStatusLabel1.Text = "";
            }
            else
                MessageBox.Show("Unesi ispravan ID!");
        }
        private void izadjiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void visina_numeric_ValueChanged(object sender, EventArgs e)
        {
            if (zenskoRB.Checked == true)
                bodymass_numeric.Value = visina_numeric.Value - 110;
            else
                bodymass_numeric.Value = visina_numeric.Value - 100;
        }

        private void trener_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            trenerID_masked_box.Text = Convert.ToString(trener_combo.Text);
        }

        private void nutricionista_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nutricionistaID_masked_box.Text = Convert.ToString(nutricionista_combo.Text);
        }

        private void bodymass_numeric_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
