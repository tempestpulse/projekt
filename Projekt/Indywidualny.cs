namespace Projekt;

class Indywidualny : Bilet {
private string imie="";
private string nazwisko="";
private string narodowosc="";
private int wiek;
public Indywidualny(string imie, string nazwisko, string narodowosc, int wiek, string miejsceOdlotu, string miejsceDocelowe, DateTime data){
    this.imie = imie;
    this.nazwisko = nazwisko;
    this.narodowosc = narodowosc;
    this.wiek = wiek;
    this.miejsceOdlotu = miejsceOdlotu;
    this.miejsceDocelowe = miejsceDocelowe;
    this.data = data;
}

public override string getImie(){
    return this.imie;

}

public override string getNazwisko(){
    return this.nazwisko;
    
}

public override string getNarodowosc(){
    return this.narodowosc;
    
}

public override int getWiek(){
    return this.wiek;
    
}

}
