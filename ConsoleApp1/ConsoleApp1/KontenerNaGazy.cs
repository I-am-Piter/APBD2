namespace ConsoleApp1;

public class KontenerNaGazy : Kontener
{
    private double cisnienie;
    private string nazwaGazu;
    public KontenerNaGazy(double wysokosc, double glebokosc, double wagaWlasna, double maxLadownosc,double cisnienie) : base(wysokosc, glebokosc, wagaWlasna, maxLadownosc)
    {
        string newNumerSeryjny = "KON-G-" + (Kontener.lastNum++);
        setNumerSeryjny(newNumerSeryjny);
        this.cisnienie = cisnienie;
    }
    
    public void load(String nazwaGazu, double masaLadunku)
    {
        if (masaLadunku+getMasaLadunku() > getMaxLadownosc())
        {
            throw new Overfill_exc("przekroczono maksymalną masę ładunku w tym kontenerze");
        }

        this.nazwaGazu = nazwaGazu;
        this.setMasaLadunku(getMasaLadunku()+masaLadunku);
    }

    public string unload()
    {
        double rozladowano = (getMasaLadunku()-(getMasaLadunku() * 0.05));
        setMasaLadunku(getMasaLadunku()*0.05);
        return "rozladowano " + rozladowano + " kg gazu: " + nazwaGazu;
    }
    
}