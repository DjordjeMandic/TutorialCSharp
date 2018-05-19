namespace Classes
{
    internal class Macka : Zivotinja
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