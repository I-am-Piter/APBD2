namespace ConsoleApp1;

public class KontenerChlodniczy : Kontener
{
    private string rodzajProduktu;
    private double temperatura;

    public KontenerChlodniczy(double wysokosc, double glebokosc, double wagaWlasna, double maxLadownosc,double temperatura) : base(wysokosc, glebokosc, wagaWlasna, maxLadownosc)
    {
        this.temperatura = temperatura;
        string newNumerSeryjny = "KON-C-" + (Kontener.lastNum++);
        setNumerSeryjny(newNumerSeryjny);
    }

    public void load(String rodzajProduktu, double masaLadunku)
    {
        if (masaLadunku+getMasaLadunku() > getMaxLadownosc())
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