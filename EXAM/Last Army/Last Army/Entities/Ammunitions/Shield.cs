
public class Shield : Ammunition
{
    private const double WeightFactor = 3.7;

    public Shield(string name)
        : base(name, WeightFactor)
    {
    }
}
