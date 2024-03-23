using ConsoleApp1;

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
        KontenerChlodniczy chlodniczy = new KontenerChlodniczy(50, 50, 100, 1000,15);
        KontenerChlodniczy chlodniczy2 = new KontenerChlodniczy(50, 50, 100, 1000,15);
        KontenerChlodniczy chlodniczy3 = new KontenerChlodniczy(50, 50, 100, 1000,15);
        KontenerNaGazy gazy = new KontenerNaGazy(50, 50, 100, 1000,50);
        KontenerNaGazy gazy2 = new KontenerNaGazy(50, 50, 100, 1000,50);
        KontenerNaGazy gazy3 = new KontenerNaGazy(50, 50, 100, 1000,50);
        KontenerNaPlyny plyny = new KontenerNaPlyny(50, 50, 100, 1000);
        KontenerNaPlyny plyny2 = new KontenerNaPlyny(50, 50, 100, 1000);
        KontenerNaPlyny plyny3 = new KontenerNaPlyny(50, 50, 100, 1000);

        List<Kontener> konteners = new List<Kontener>();
        konteners.Add(chlodniczy2);
        konteners.Add(plyny2);
        konteners.Add(chlodniczy3);
        
        plyny2.load("woda",500,false);
        
        chlodniczy.load("banany", 100);
        gazy.load("argon",100);
        plyny.load("woda",300,false);

        Kontenerowiec kontenerowiec1 = new Kontenerowiec(10, 100, 20000);
        Kontenerowiec kontenerowiec2 = new Kontenerowiec(10, 100, 20000);
        
        kontenerowiec1.load(chlodniczy);
        kontenerowiec1.load(konteners);
        kontenerowiec1.load(gazy);
        
        kontenerowiec1.transferToShip(kontenerowiec2,gazy.getNumerSeryjny());
        
        kontenerowiec1.unloadContainer(chlodniczy.getNumerSeryjny());

        chlodniczy.unload();
        
        kontenerowiec1.swapContainers(plyny2.getNumerSeryjny(),plyny3);
        
        plyny2.printData();
        kontenerowiec1.printData();
        
        

    }

    public void printData()
    {
        Console.WriteLine("masa ładunku: "+ this.masaLadunku + " wysokość: " + this.wysokosc + " glebokosc: " + this.glebokosc + " wagaWlasna: " + this.wagaWlasna + " maxLadownosc: " + this.maxLadownosc + " numerSeryjny: " + this.numerSeryjny);
    }

    public void setNumerSeryjny(string numer)
    {
        numerSeryjny = numer;
    }

    public double getMasaWlasna()
    {
        return this.wagaWlasna;
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