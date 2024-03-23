public class Kontener
{
    private double masaLadunku;
    private double wysokosc;
    private double glebokosc;
    private double wagaWlasna;
    private double maxLadownosc;
    private string numerSeryjny;
    public static int lastNum;

    protected Kontener(double wysokosc, double glebokosc, double wagaWlasna, double maxLadownosc)
    {
        this.masaLadunku = 0.0;
        this.wysokosc = wysokosc;
        this.glebokosc = glebokosc;
        this.wagaWlasna = wagaWlasna;
        this.maxLadownosc = maxLadownosc;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public void setNumerSeryjny(string numer)
    {
        numerSeryjny = numer;
    }

    public string getNumerSeryjny()
    {
        return this.numerSeryjny;
    }

    public void setMasaLadunku(double masaLadunku)
    {
        this.masaLadunku = masaLadunku;
    }
    
    public double getMasaLadunku()
    {
        return masaLadunku;
    }

    public double getMaxLadownosc()
    {
        return maxLadownosc;
    }
}