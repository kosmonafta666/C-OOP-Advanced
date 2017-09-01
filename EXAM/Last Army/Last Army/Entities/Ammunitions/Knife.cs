
public class Knife : Ammunition
{
    private const double WeightFactor = 0.4;

    public Knife(string name)
        : base (name, WeightFactor)
    {
    }
}
