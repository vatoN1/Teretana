using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeretanaBilderhana
{
    class Osoba
    {
        private DateTime datumRodjenja
        {
            get;
            set;
        }

        private int ID
        {
            get;
            set;
        }

        private string ime
        {
            get;
            set;
        }

        private string prezime
        {
            get;
            set;
        }

        private Spol spol
        {
            get;
            set;
        }
    }
}
