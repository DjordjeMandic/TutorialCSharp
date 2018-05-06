namespace Generics
{
    public class NasaLista<Tip>
    {
        private Tip[] array;
        public NasaLista(int velicina)
        {
            array = new Tip[velicina + 1];
        }

        public Tip ProcitajVrednost(int index)
        {
            return array[index];
        }

        public void NamestiVrednost(int index, Tip vrednost)
        {
            array[index] = vrednost;
        }
    }
}
