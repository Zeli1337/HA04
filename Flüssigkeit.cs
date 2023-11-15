namespace main;

public class Flüssigkeit
{
    private double _menge;
    public double Menge{
        set => _menge = value>0?value:throw new Exception("Wert kleiner gleich Null");
        get => _menge;
    }

    public Flüssigkeit(double menge){
        Menge = menge;
    }
}
