namespace ConsoleApp1;

public class Kontenerowiec
{
    private List<Kontener> containers;
    private double maxPredkosc;
    private int maxKontenerow;
    private double maxWaga;
    private int id;
    private static int lastId;

    public Kontenerowiec(double maxPredkosc, int maxKontenerow, double maxWaga)
    {
        containers = new List<Kontener>();
        this.maxKontenerow = maxKontenerow;
        this.maxWaga = maxWaga;
        this.maxPredkosc = maxPredkosc;
        this.id = (++lastId);
    }

    public void load(Kontener kontener)
    {
        if ((getActualMass(containers) + (kontener.getMasaLadunku()+kontener.getMasaWlasna()) < maxWaga)&&(containers.Count + 1 <= maxKontenerow))
        {
            this.containers.Add(kontener);
        }
        else
        {
            Console.WriteLine("za dużo kontenerów, albo za duża masa");
        }
    }

    public void load(List<Kontener> kontenery)
    {
        if ((getActualMass(containers) + getActualMass(kontenery) < maxWaga)&&(containers.Count + kontenery.Count <= maxKontenerow))
        {
            foreach (Kontener kontener in kontenery)
            {
                this.containers.Add(kontener);
            }
        }
        else
        {
            Console.WriteLine("za dużo kontenerów, albo za duża masa");
        }
    }

    public void unloadContainer(string serialNum)
    {
        for (int i = 0; i > containers.Count(); i++)
        {
            if (containers.ElementAt(i).getNumerSeryjny().Equals(serialNum))
            {
                containers.Remove(containers.ElementAt(i));

                break;
            }
        }
    }

    public void swapContainers(string serialNum, Kontener container)
    {
        for (int i = 0; i > containers.Count(); i++)
        {
            if (containers.ElementAt(i).getNumerSeryjny().Equals(serialNum))
            {
                if (getActualMass(containers) + container.getMasaLadunku() + container.getMasaWlasna() < maxWaga)
                {
                    containers.Remove(containers.ElementAt(i));
                    containers.Add(container);
                }

                break;
            }
        }
    }

    public void transferToShip(Kontenerowiec destination, string containerSerialNum)
    {
        for (int i = 0; i > containers.Count(); i++)
        {
            if (containers.ElementAt(i).getNumerSeryjny().Equals(containerSerialNum))
            {
                if (destination.getMaxWaga() <= (getActualMass(destination.containers) + containers.ElementAt(i).getMasaLadunku() + containers.ElementAt(i).getMasaWlasna()))
                {
                    destination.load(containers.ElementAt(i));
                    containers.Remove(containers.ElementAt(i));
                }

                break;
            }
        }
    }

    private double getMaxWaga()
    {
        return this.maxWaga;
    }

    private static double getActualMass(List<Kontener> toMeasure)
    {
        double actualMass = 0;
        foreach (Kontener kontener in toMeasure)
        {
            actualMass += kontener.getMasaLadunku() + kontener.getMasaWlasna();
        }

        return actualMass;
    }

    public void printData()
    {
        Console.WriteLine("maxpredkosc: "+ maxPredkosc + " maxIloscKontenerow: "+maxKontenerow + " maxWaga "+ maxWaga + " idStatku " + id + " Kontenery na statku:");

        foreach (Kontener kontener in containers)
        {
            kontener.printData();
        }
    }
    
    

}