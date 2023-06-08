using System.Collections.Generic;

public class Lot
{
    private Trasa _trasa;
    private List<Rezerwacja> _listaRezerwacji;
    private string _rodzajLotu;
    private Samolot _samolot;

    public Lot(Samolot samolot, Trasa trasa, List<Rezerwacja> listaRezerwacji, string rodzajLotu)
    {
        _trasa = trasa;
        _listaRezerwacji = listaRezerwacji;
        _rodzajLotu = rodzajLotu;
        _samolot = samolot;
    }

    public List<Rezerwacja> GetRezerwacje()
    {
        return _listaRezerwacji;
    }

    public Samolot GetSamolot()
    {
        return _samolot;
    }

    public Trasa GetTrasa()
    {
        return _trasa;
    }

    public void DodajRezerwacje(Rezerwacja rezerwacja)
    {
        _listaRezerwacji.Add(rezerwacja);
    }

    public void UsunRezerwacje(Rezerwacja rezerwacja)
    {
        _listaRezerwacji.Remove(rezerwacja);
    }

    public string GetRodzajLotu()
    {
        return _rodzajLotu;
    }
}