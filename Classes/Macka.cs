using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Macka : Zivotinja
    {
        private bool _volidasemazi;
        public Macka(string ime, int starost, Pol pol, bool volidasemazi) : base(ime, starost, pol)
        {
            _volidasemazi = volidasemazi;
        }

        public bool VoliDaSeMazi
        {
            get
            {
                return _volidasemazi;
            }

            set
            {
                _volidasemazi = value;
            }
        }
    }
}
