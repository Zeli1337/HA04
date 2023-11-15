namespace main;

public class Mischung : Flüssigkeit
{
    private string _anteil1;
    private string _anteil2;
    private double _verhältnis;
    public string Anteil1{
        get => _anteil1;
        set => _anteil1 = String.IsNullOrEmpty(value)|| String.IsNullOrWhiteSpace(value)? throw new Exception("Fehlerhafter Wert"):value;
    }
    
    public string Anteil2{
        get => _anteil2;
        set => _anteil2 = String.IsNullOrEmpty(value)|| String.IsNullOrWhiteSpace(value)? throw new Exception("Fehlerhafter Wert"):value;
    }

    public double Verhältnis{
        get => _verhältnis;
        set => _verhältnis = value<1&&value>0?value:throw new Exception("Verhältnis Wert falsch");
    }
    public Mischung(double menge, string ant1, string ant2, double verhält):base(menge){
        Verhältnis = verhält;
        Anteil1 = ant1;
        Anteil2 = ant2;

    }
}
