using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeretanaBilderhana
{
    class Trener : Osoba
    {
        public Trener()
        {

        }

        private string komentar
        {
            get;
            set;
        }

        public virtual WorkoutProgram noviProgram()
        {
            throw new System.NotImplementedException();
        }

        public virtual void azurirajProgram()
        {
            throw new System.NotImplementedException();
        }
    }
}
