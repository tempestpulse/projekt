namespace Projekt;

class Rezerwacja {
    private List<Bilet> bilety;
    
    public Rezerwacja()
    {
        bilety = new List<Bilet>();
    }

    public List<Bilet> getBilety(){
        return bilety;
    }

    public void dodajBilet(Bilet bilet){
        bilety.Add(bilet);
    }

    public void usunBilet(Bilet bilet){
        bilety.Remove(bilet);
    }
}
