namespace Projekt
{
    public class Samolot
    {
        private float _zasieg;
        private string _id;
        private int _liczbamiejsc;

        public Samolot(float zasieg, string id, int liczbamiejsc)
        {
            _zasieg = zasieg;
            _id = id;
            _liczbamiejsc = liczbamiejsc;
        }

        public float GetZasieg()
        {
            return _zasieg;
        }

        public string GetId()
        {
            return _id;
        }

        public int GetLiczbamiejsc()
        {
            return _liczbamiejsc;
        }
    }
}