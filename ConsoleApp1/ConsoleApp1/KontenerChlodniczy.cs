namespace ConsoleApp1;

public class KontenerChlodniczy : Kontener
{
    private string rodzajProduktu;
    private double temperatura;

    protected KontenerChlodniczy(double wysokosc, double glebokosc, double wagaWlasna, double maxLadownosc) : base(wysokosc, glebokosc, wagaWlasna, maxLadownosc)
    {
        string newNumerSeryjny = "KON-C-" + (Kontener.lastNum++);
        setNumerSeryjny(newNumerSeryjny);
    }

    public void load(String rodzajProduktu, double masaLadunku)
    {
        if (masaLadunku > getMaxLadownosc())
        {
            throw new Overfill_exc("za duża masa ładunku na ten kontener");
        }
        this.rodzajProduktu = rodzajProduktu;
        this.setMasaLadunku(getMasaLadunku()+masaLadunku);
    }

    public string unload()
    {
        setMasaLadunku(0);
        return "rozladowano " + getMasaLadunku() + " kg produktu: " + rodzajProduktu;
    }
    
}