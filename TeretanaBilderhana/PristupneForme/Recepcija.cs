using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeretanaBilderhana.PristupneForme;
//using System.Drawing.Imaging;
//using System.Drawing.Design;

namespace TeretanaBilderhana.PristupneForme
{
    public partial class Recepcija : Form
    {
        public Recepcija()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {   
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_MouseHover(object sender, EventArgs e)
        {
            toolStripButton1.Text = "Unos novog klijenta";
        }

        private void toolStripButton2_MouseHover(object sender, EventArgs e)
        {
            toolStripButton2.Text = "Formiranje racuna za jednokratnog korisnika";
        }

        private void toolStripButton3_MouseHover(object sender, EventArgs e)
        {
            toolStripButton3.Text = "Recepcioner izvjestaj";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Klijenti.DodavanjeKlijenata k = new Klijenti.DodavanjeKlijenata();
            k.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RacunUnos r = new RacunUnos();
            r.Show();
        }



        private void toolStripButton3_Click(object sender, EventArgs e)
        {
//            Izvjestaji.DodavanjeIzvjestaja iz = new Izvjestaji.DodavanjeIzvjestaja();
//            iz.Show();
            IzvjestajForma i = new IzvjestajForma();
            i.Show();
        }

        private void dateTimePicker1_ControlAdded(object sender, ControlEventArgs e)
        {
            dateTimePicker1.Value.AddHours(DateTime.Now.Hour);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.Value.TimeOfDay.Equals(DateTime.Now.TimeOfDay);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Recepcija_Load(object sender, EventArgs e)
        {
        }

        public int br = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            br++;
            Bitmap myBitmap;
            if (br%2 == 1)
                 myBitmap = new Bitmap(@"C:\Users\A\Desktop\asd.jpg");
            else
                 myBitmap = new Bitmap(@"C:\Users\A\Desktop\Screenshot_2.png");
            Graphics g = Graphics.FromImage(myBitmap);
                        this.BackgroundImage = myBitmap; 
            Point p = new Point(0,0);
            g.DrawImage(myBitmap,p);
           
        }

       
    }
}
