namespace Projekt;

public class Rezerwacja
{
    public List<Bilet> bilety;

    public Rezerwacja()
    {
        bilety = new List<Bilet>();
    }

    public List<Bilet> getBilety()
    {
        return this.bilety;
    }
    public void dodajBilet(Bilet bilet)
    {
        bilety.Add(bilet);
    }

    public void usunBilet(Bilet bilet)
    {
        bilety.Remove(bilet);
    }
}
