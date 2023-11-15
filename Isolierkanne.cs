using main;



public class Isolierkanne : Kanne
{
    private int _temperaturerhaltung;
    public int Temperaturerhaltung{
        set=>_temperaturerhaltung = value>0?value:throw new Exception("Temp");
        get=> _temperaturerhaltung;
    }

    public Isolierkanne( double ff,  Flüssigkeit fl, int temp ):base(ff, fl){
        Temperaturerhaltung = temp;
    }

    public override string Darstellung()
    {
        return $"{base.Darstellung()} {_temperaturerhaltung}";
    }


}
