using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeretanaBilderhana
{
    class Uposlenik : Osoba
    {
        private decimal plata
        {
            get;
            set;
        }

        private DateTime datumZaposlenja
        {
            get;
            set;
        }

        public virtual Izvjestaj kreirajIzvjestaj()
        {
            throw new System.NotImplementedException();
        }

        public virtual void azurirajPodatke()
        {
            throw new System.NotImplementedException();
        }
    }
}
