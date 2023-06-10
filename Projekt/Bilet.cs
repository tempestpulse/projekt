namespace Projekt;

class Bilet {

    protected string miejsceOdlotu="";
    protected string miejsceDocelowe="";
    protected DateTime data;

    public string getMiejsceDocelowe()
    {
        return this.miejsceDocelowe;
    }

    public string getMiejsceOdlotu()
    {
        return this.miejsceOdlotu;
    }

    public DateTime getData(){
        return  this.data;
    }

    public virtual string getNazwaFirmy(){
    return "";

    }

    public virtual string getNip(){
        return "";
        
    }

    public virtual string getImie(){
        return "";

    }

    public virtual string getNazwisko(){
        return "";
        
    }

    public virtual string getNarodowosc(){
        return "";
        
    }

    public virtual int getWiek(){
        return 0;
        
    }

}
