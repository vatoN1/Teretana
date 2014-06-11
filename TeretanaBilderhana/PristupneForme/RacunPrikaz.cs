using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace TeretanaBilderhana.PristupneForme
{
    public partial class RacunPrikaz : Form
    {
        private string p1;
        private decimal p2;
        private int p3;
        private decimal p4;

        public RacunPrikaz()
        {
            InitializeComponent();
        }

        public RacunPrikaz(string p1, decimal p2, int p3, decimal p4)
        {
            // TODO: Complete member initialization
            this.p1 = p1; // usluga
            this.p2 = p2; // cijena
            this.p3 = p3; // kolicina
            this.p4 = p4; // za platiti
            InitializeComponent();
        }


        public static string GetRandomAlphanumericString(int length)
        {
            const string alphanumericCharacters =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "0123456789";
            return GetRandomString(length, alphanumericCharacters);
        }

        public static string GetRandomString(int length, IEnumerable<char> characterSet)
        {
            if (length < 0)
                throw new ArgumentException("length must not be negative", "length");
            if (length > int.MaxValue / 8) // 250 million chars ought to be enough for anybody
                throw new ArgumentException("length is too big", "length");
            if (characterSet == null)
                throw new ArgumentNullException("characterSet");
            var characterArray = characterSet.Distinct().ToArray();
            if (characterArray.Length == 0)
                throw new ArgumentException("characterSet must not be empty", "characterSet");

            var bytes = new byte[length * 8];
            new RNGCryptoServiceProvider().GetBytes(bytes);
            var result = new char[length];
            for (int i = 0; i < length; i++)
            {
                ulong value = BitConverter.ToUInt64(bytes, i * 8);
                result[i] = characterArray[value % (uint)characterArray.Length];
            }
            return new string(result);
        }


        private void Racun_Load(object sender, EventArgs e)
        {

            string jib = GetRandomAlphanumericString(6);
            label14.Text = jib;
            string pib = GetRandomAlphanumericString(6);
            label15.Text = pib;
            string bf = GetRandomAlphanumericString(6);
            label18.Text = bf;
            string rand_alphanum = GetRandomAlphanumericString(13);
            label41.Text = rand_alphanum;

            label19.Text = Convert.ToString(DateTime.Now);

            label36.Text = Convert.ToString(p4);
            label37.Text = Convert.ToString(p4);
            label38.Text = Convert.ToString(p4);

            label33.Text = Convert.ToString(Math.Round (p4 - (p4 * 0.17m) , 2 ));
            label34.Text = Convert.ToString( Math.Round (p4 * 0.17m, 2));
            label35.Text = Convert.ToString(Math.Round (p4 * 0.17m, 2));

            label21.Text = p1;
            label22.Text = Convert.ToString(p3);
            label23.Text = Convert.ToString(p2);
            label24.Text = Convert.ToString(p4) + "E";
            DateTime t = DateTime.Now.AddSeconds(-7);
            label44.Text = "Vrijeme ulaska: " + Convert.ToString(DateTime.Now );
            label45.Text = "Vrijeme izlaska: " + Convert.ToString(t);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
