
public class Helmet : Ammunition
{
    private const double WeightFactor = 2.3;

    public Helmet(string name) 
        : base (name, WeightFactor)
    {
    }
}
