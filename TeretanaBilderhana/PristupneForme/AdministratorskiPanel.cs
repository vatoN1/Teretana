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
using TeretanaBilderhana.Oprema;
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

    }
}
