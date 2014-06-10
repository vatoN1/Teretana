using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeretanaBilderhana.Klijenti;
using TeretanaBilderhana.Izvjestaji;
using TeretanaBilderhana.Opreme;
using TeretanaBilderhana.Prehrambeni_programi;
using TeretanaBilderhana.Prostorije;
using TeretanaBilderhana.Sprave;
using TeretanaBilderhana.Suplementi;
using TeretanaBilderhana.WorkoutProgrami;

namespace TeretanaBilderhana.PristupneForme
{
    public partial class AdministratorskiPanel : Form
    {
        public AdministratorskiPanel()
        {
            InitializeComponent();
        }

        private void unosuposlenicibutton_Click(object sender, EventArgs e)
        {
            DodavanjeUposlenika a = new DodavanjeUposlenika();
            a.Show();
        }

        private void unosklijentibutton_Click(object sender, EventArgs e)
        {
            DodavanjeKlijenata d = new DodavanjeKlijenata();
            d.Show();
        }

        private void unosizvjestajibutton_Click(object sender, EventArgs e)
        {
            DodavanjeIzvjestaja i = new DodavanjeIzvjestaja();
            i.Show();
        }

        private void unosopremabutton_Click(object sender, EventArgs e)
        {
            DodavanjeOpreme o = new DodavanjeOpreme();
            o.Show();
        }

        private void unosspavebutton_Click(object sender, EventArgs e)
        {
            DodavanjeSprava s = new DodavanjeSprava();
            s.Show();
        }

        private void unossuplementibutton_Click(object sender, EventArgs e)
        {
            DodavanjeSuplemenata s = new DodavanjeSuplemenata();
            s.Show();
        }

        private void unosprostorijebutton_Click(object sender, EventArgs e)
        {
            DodavanjeProstorija p = new DodavanjeProstorija();
            p.Show();
        }

        private void unospprogramibutton_Click(object sender, EventArgs e)
        {
            DodavanjePrehrambenihPrograma pp = new DodavanjePrehrambenihPrograma();
            pp.Show();
        }

        private void unoswprogramibutton_Click(object sender, EventArgs e)
        {
            DodavanjeWorkoutPrograma wp = new DodavanjeWorkoutPrograma();
            wp.Show();
        }

        private void azuriranjeuposlenicibutton_Click(object sender, EventArgs e)
        {
            EditovanjeUposlenika u = new EditovanjeUposlenika();
            u.Show();
        }

        private void izjestajiazuriranjebutton_Click(object sender, EventArgs e)
        {
            EditovanjeIzvjestaja i = new EditovanjeIzvjestaja();
            i.Show();
        }

        private void azuriranjeklijentibutton_Click(object sender, EventArgs e)
        {
            EditovanjeKlijenata k = new EditovanjeKlijenata();
            k.Show();
        }

        private void a_Click(object sender, EventArgs e)
        {
            EditovanjeOpreme o = new EditovanjeOpreme();
            o.Show();
        }

        private void azuriranjespravebutton_Click(object sender, EventArgs e)
        {
            EditovanjeSprava s = new EditovanjeSprava();
            s.Show();
        }

        private void azuriranjesuplementibutton_Click(object sender, EventArgs e)
        {
            EditovanjeSuplemenata s = new EditovanjeSuplemenata();
            s.Show();
        }

        private void azuriranjeprostorijebutton_Click(object sender, EventArgs e)
        {
            EditovanjeProstorija p = new EditovanjeProstorija();
            p.Show();
        }

        private void azuriranjepprogramibutton_Click(object sender, EventArgs e)
        {
            EditovanjePrehrambenihPrograma pp = new EditovanjePrehrambenihPrograma();
            pp.Show();
        }

        private void azuriranjewprogramibutton_Click(object sender, EventArgs e)
        {
            EditovanjeWorkoutPrograma wp = new EditovanjeWorkoutPrograma();
            wp.Show();
        }

        private void pregledsljedecibutton_Click(object sender, EventArgs e)
        {
            Admintabcontrol.SelectedTab = unostab;
        }

        private void unosprethodnibutton_Click(object sender, EventArgs e)
        {
            Admintabcontrol.SelectedTab = pregledtab;
        }

        private void unossljedecitab_Click(object sender, EventArgs e)
        {
            Admintabcontrol.SelectedTab = azuriranjetab;
        }

        private void azuriranjeprethodnibutton_Click(object sender, EventArgs e)
        {
            Admintabcontrol.SelectedTab = unostab;
        }

        private void azuriranjesljedecibutton_Click(object sender, EventArgs e)
        {
            Admintabcontrol.SelectedTab = brisanjetab;
        }

        private void brisanjeprethodnibutton_Click(object sender, EventArgs e)
        {
            Admintabcontrol.SelectedTab = azuriranjetab;
        }

        private void brisanjesljedecibutton_Click(object sender, EventArgs e)
        {
            Admintabcontrol.SelectedTab = uplateisplatetab;
        }

        private void uplateprethodnibutton_Click(object sender, EventArgs e)
        {
            Admintabcontrol.SelectedTab = brisanjetab;
        }

        private void pregledunosbutton_Click(object sender, EventArgs e)
        {
            Uposlenici.Pregled pregled = new Uposlenici.Pregled();
            pregled.Show();
        }

        private void pregledizvjestajibutton_Click(object sender, EventArgs e)
        {
            Izvjestaji.Pregled pregled = new Izvjestaji.Pregled();
            pregled.Show();
        }

        private void pregledklijentibutton_Click(object sender, EventArgs e)
        {
            Klijenti.Pregled pregled = new Klijenti.Pregled();
            pregled.Show();
        }

        private void pregledopremabutton_Click(object sender, EventArgs e)
        {
            Opreme.Pregled pregled = new Opreme.Pregled();
            pregled.Show();
        }

        private void pregledspravebutton_Click(object sender, EventArgs e)
        {
            Sprave.Pregled pregled = new Sprave.Pregled();
            pregled.Show();
        }

        private void pregledsuplementibutton_Click(object sender, EventArgs e)
        {
            Suplementi.Pregled pregled = new Suplementi.Pregled();
            pregled.Show();
        }

        private void pregledprostorijebutton_Click(object sender, EventArgs e)
        {
            Prostorije.Pregled pregled = new Prostorije.Pregled();
            pregled.Show();
        }

        private void pregledpprogramibutton_Click(object sender, EventArgs e)
        {
            Prehrambeni_programi.Pregled pregled = new Prehrambeni_programi.Pregled();
            pregled.Show();
        }

        private void pregledwprogramibutton_Click(object sender, EventArgs e)
        {
            WorkoutProgrami.Pregled pregled = new WorkoutProgrami.Pregled();
            pregled.Show();
        }

        private void brisanjeuposlenicibutton_Click(object sender, EventArgs e)
        {
            Uposlenici.BrisanjeUposlenika b = new Uposlenici.BrisanjeUposlenika();
            b.Show();
        }

        private void brisanjeklijentibutton_Click(object sender, EventArgs e)
        {
            Klijenti.BrisanjeKlijenata b = new BrisanjeKlijenata();
            b.Show();
        }




    }
}
