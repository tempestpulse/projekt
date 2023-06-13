namespace Projekt
{


    public class Trasa
    {
        public float _dystans;
        public float _czas;
        public List<Lotnisko> _lotniska;
        public string _id;

        public Trasa(float dystans, float czas, List<Lotnisko> lotniska, string id)
        {
            _dystans = dystans;
            _czas = czas;
            _lotniska = lotniska;
            _id = id;
        }

        public float GetDystans()
        {
            return _dystans;
        }

        public List<Lotnisko> GetLotniska()
        {
            return _lotniska;
        }

        public void DodajLotnisko(Lotnisko lotnisko)
        {
            _lotniska.Add(lotnisko);
        }

        public void UsunLotnisko()
        {
            _lotniska.RemoveAt(_lotniska.Count - 1);
        }

        public float GetCzas()
        {
            return _czas;
        }

        public string GetID()
        {
            return _id;
        }
    }
}
