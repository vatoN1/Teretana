using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeretanaBilderhana
{
    class Nutricionista : Osoba
    {
        private string komentar
        {
            get;
            set;
        }

        public virtual void azurirajProgram()
        {
            throw new System.NotImplementedException();
        }

        public virtual PrehrambeniProgram noviProgram()
        {
            throw new System.NotImplementedException();
        }
    }
}
