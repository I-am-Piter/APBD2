namespace ConsoleApp1;

public class Kontenerowiec
{
    private List<Kontener> containers;
    private double maxPredkosc;
    private int maxKontenerow;
    private double maxWaga;

    public Kontenerowiec(double maxPredkosc, int maxKontenerow, double maxWaga)
    {
        containers = new List<Kontener>();
        this.maxKontenerow = maxKontenerow;
        this.maxWaga = maxWaga;
        this.maxPredkosc = maxPredkosc;
    }

    public void load(Kontener kontener)
    {
        this.containers.Add(kontener);
    }
}