using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeretanaBilderhana
{
    class Administrator : Osoba
    {
        private List<Izvjestaj>izvjestaji
        {
            get;
            set;
        }

        public virtual void registrujUposlenika(Uposlenik uposlenik)
        {
            throw new System.NotImplementedException();
        }

        public virtual void obradiIzvjestaj()
        {
            throw new System.NotImplementedException();
        }
    }
}
