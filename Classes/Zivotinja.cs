using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Zivotinja : InterfaceTutorial
    {
        public enum Pol
        {
            Musko,
            Zensko
        }

        private string _ime;
        private int _starost;
        private Pol _pol;

        public Zivotinja(string ime, int starost, Pol pol)
        {
            _ime = ime;
            _starost = starost;
            _pol = pol;
        }

        public string Ime
        {
            get
            {
                return _ime;
            }

            set
            {
                _ime = value;
            }
        }

        public int Starost
        {
            get
            {
                return _starost;
            }

            set
            {
                _starost = value;
            }
        }

        public Pol PolZivotinje
        {
            get
            {
                return _pol;
            }

            set
            {
                _pol = value;
            }
        }

        public void haha()
        {
            Console.WriteLine("ahahahhahahaha");
        }

        public void tuzan()
        {
            Console.WriteLine(":(");
        }
    }
}
