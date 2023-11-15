namespace main;

public class Kanne
{
    private double _fassungsvermögen;
    public double Fassungsvermögen{
        get=> _fassungsvermögen;
        set=> _fassungsvermögen = value>0?value:throw new Exception("Wert negativ");
    }
    private Flüssigkeit _flüssigkeit;

    
    public Kanne(double ff, Flüssigkeit fl){
        if(fl == null || fl.Menge>ff){
            throw new Exception("Unpassendes Objekt übergeben");
        }
        

        Fassungsvermögen = ff;
        _flüssigkeit = fl;
    }
    

    public virtual string Darstellung(){
        if(_flüssigkeit is Mischung){
            Mischung mische = _flüssigkeit as Mischung;
            return $"{mische.Anteil1} {mische.Anteil2} {mische.Verhältnis} {mische.Menge} ";
        }else{
            
            return $"{_flüssigkeit.Menge} ";
        }
    }

}
