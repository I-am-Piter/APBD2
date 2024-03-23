namespace ConsoleApp1;

public class KontenerNaPlyny : Kontener,IHazardNotifier
{
    private string rodzajPlynu;
    public KontenerNaPlyny(double wysokosc, double glebokosc, double wagaWlasna, double maxLadownosc) : base(wysokosc, glebokosc, wagaWlasna, maxLadownosc)
    {
        string newNumerSeryjny = "KON-L-" + (Kontener.lastNum++);
        setNumerSeryjny(newNumerSeryjny);
    }
    
    public void load(String rodzajPlynu, double masaLadunku,bool niebezpiecznyLadunek)
    {
        
        if(niebezpiecznyLadunek)
        {
            if (masaLadunku > (0.5 * getMaxLadownosc()))
            {
                HazardNotify();
            }            
        }
        else
        {
            if (masaLadunku > (0.9 * getMaxLadownosc()))
            {
                HazardNotify();
            }
        }
        
        if (masaLadunku > getMaxLadownosc())
        {
            throw new Overfill_exc("za duża masa ładunku na ten kontener");
        }
        this.rodzajPlynu = rodzajPlynu;
        this.setMasaLadunku(getMasaLadunku()+masaLadunku);
    }

    public string unload()
    {
        setMasaLadunku(0);
        return "rozladowano " + getMasaLadunku() + " kg plynu: " + rodzajPlynu;
    }

    public void HazardNotify()
    {
        Console.WriteLine("kontener o numerze: "+getNumerSeryjny()+" jest w niebezpieczenstwie.");
    }
}