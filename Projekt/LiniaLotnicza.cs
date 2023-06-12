using System;
using System.IO;
using Newtonsoft.Json;



namespace Projekt;


public class LiniaLotnicza
{
    private string nazwalinii;
    private List<Samolot> samoloty = new List<Samolot>();
    private List<Lot> loty = new List<Lot>();
    private List<Trasa> trasy = new List<Trasa>();
    private List<Bilet> bilety = new List<Bilet>();

    public LiniaLotnicza()
    {
        this.nazwalinii = null;
        this.samoloty = null;
        this.loty = null;
        this.trasy = null;
        this.bilety = null;
    }

    public LiniaLotnicza(string nazwalinii, List<Samolot> samoloty, List<Lot> loty, List<Trasa> trasy, List<Bilet> bilety)
    {
        this.nazwalinii = nazwalinii;
        this.samoloty = samoloty;
        this.loty = loty;
        this.trasy = trasy;
        this.bilety = bilety;
    }
    public string GetNazwaLinii()
    {
        return nazwalinii;
    }
    public List<Samolot> GetSamoloty() { return samoloty; }
    public List<Lot> GetLoty() { return loty; }
    public List<Trasa> GetTrasa() { return trasy; }
    public List<Bilet> GetBilety() { return bilety; }
    public void DodajSamolot(Samolot samolot)
    {
        samoloty.Add(samolot);
    }
    public void UsunSamolot(Samolot samolot)
    {
        samoloty.Remove(samolot);
    }
    public void DodajTrase(Trasa trasa)
    {
        trasy.Add(trasa);
    }
    public void UsunTrase(Trasa trasa)
    {
        trasy.Remove(trasa);
    }


    public void GenerujLot(Samolot samolot, Trasa trasa, List<Rezerwacja> listaRezerwacji, string rodzajLotu)
    {
        Lot lot = new Lot(samolot, trasa, listaRezerwacji, rodzajLotu);
        this.loty.Add(lot);

    }
    public void Zapis(string nazwa)
    {


        string jsonStringNazwa = JsonConvert.SerializeObject(nazwalinii);
        string jsonStringSamoloty = JsonConvert.SerializeObject(samoloty);
        string jsonStringLoty = JsonConvert.SerializeObject(loty);
        string jsonStringTrasy = JsonConvert.SerializeObject(trasy);
        string jsonStringBilety = JsonConvert.SerializeObject(bilety);

        File.WriteAllText(nazwa + "Nazwa" + ".json", jsonStringNazwa);
        File.WriteAllText(nazwa + "Samoloty" + ".json", jsonStringNazwa);
        File.WriteAllText(nazwa + "Loty" + ".json", jsonStringNazwa);
        File.WriteAllText(nazwa + "Trasy" + ".json", jsonStringNazwa);
        File.WriteAllText(nazwa + "Bilety" + ".json", jsonStringNazwa);


    }

    public void Odczyt(string nazwa)
    {
        string json = File.ReadAllText(nazwa + "Nazwa" + ".json");
        this.nazwalinii = JsonConvert.DeserializeObject<string>(json);
        json = File.ReadAllText(nazwa + "Samoloty" + ".json");
        this.samoloty = JsonConvert.DeserializeObject<List<Samolot>>(json);
        json = File.ReadAllText(nazwa + "Loty" + ".json");
        this.loty = JsonConvert.DeserializeObject<List<Lot>>(json);
        json = File.ReadAllText(nazwa + "Trasy" + ".json");
        this.trasy = JsonConvert.DeserializeObject<List<Trasa>>(json);
        json = File.ReadAllText(nazwa + "Bilety" + ".json");
        this.bilety = JsonConvert.DeserializeObject<List<Bilet>>(json);

    }




}
