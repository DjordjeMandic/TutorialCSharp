using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Pas : Zivotinja
    {
        public enum Vrsta
        {
            sarplaninac,
            pitbul
        }

        private Vrsta _vrsta;

        public Pas(string ime, int starost, Pol pol, Vrsta vrsta) : base(ime, starost, pol)
        {
            _vrsta = vrsta;
        }

        public Vrsta VrstaPsa
        {
            get
            {
                return _vrsta;
            }

            set
            {
                _vrsta = value;
            }
        }
    }
}
