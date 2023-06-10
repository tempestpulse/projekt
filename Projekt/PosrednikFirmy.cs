namespace Projekt;

class PosrednikFirmy : Bilet {
private string nazwaFirmy="";
private string nip="";

public PosrednikFirmy(string nazwaFirmy, string nip, string miejsceOdlotu, string miejsceDocelowe, DateTime data){
    this.nazwaFirmy = nazwaFirmy;
    this.nip = nip;
    this.miejsceOdlotu = miejsceOdlotu;
    this.miejsceDocelowe = miejsceDocelowe;
    this.data = data;
}

public override string getNazwaFirmy(){
    return this.nazwaFirmy;

}

public override string getNip(){
    return this.nip;
    
}

}
