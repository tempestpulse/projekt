using System;
using System.IO;
using Newtonsoft.Json;



namespace Projekt;


public class LiniaLotnicza
{
    public string nazwalinii;
    public List<Samolot> samoloty = new List<Samolot>();
    public List<Lot> loty = new List<Lot>();
    public List<Trasa> trasy = new List<Trasa>();
    public List<Rezerwacja> bilety = new List<Rezerwacja>();

    public LiniaLotnicza()
    {

    }

    public LiniaLotnicza(string nazwalinii, List<Samolot> samoloty, List<Lot> loty, List<Trasa> trasy, List<Rezerwacja> bilety)
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
    public List<Rezerwacja> GetBilety() { return bilety; }
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


    public void GenerujLot(Samolot samolot, Trasa trasa, Rezerwacja listaRezerwacji, string rodzajLotu)
    {
        Lot lot = new Lot(samolot, trasa, listaRezerwacji, rodzajLotu);
        this.loty.Add(lot);
        this.samoloty.Add(samolot);
        this.trasy.Add(trasa);
        this.bilety.Add(listaRezerwacji);

    }
    public void Zapis(string nazwa)
    {


        string jsonStringNazwa = JsonConvert.SerializeObject(this.nazwalinii);
        string jsonStringSamoloty = JsonConvert.SerializeObject(this.samoloty);
        string jsonStringLoty = JsonConvert.SerializeObject(this.loty);
        string jsonStringTrasy = JsonConvert.SerializeObject(this.trasy);
        string jsonStringBilety = JsonConvert.SerializeObject(this.bilety);

        File.WriteAllText(nazwa + "Nazwa" + ".json", jsonStringNazwa);
        File.WriteAllText(nazwa + "Samoloty" + ".json", jsonStringSamoloty);
        File.WriteAllText(nazwa + "Loty" + ".json", jsonStringLoty);
        File.WriteAllText(nazwa + "Trasy" + ".json", jsonStringTrasy);
        File.WriteAllText(nazwa + "Bilety" + ".json", jsonStringBilety);


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
        this.bilety = JsonConvert.DeserializeObject<List<Rezerwacja>>(json);

    }




}
