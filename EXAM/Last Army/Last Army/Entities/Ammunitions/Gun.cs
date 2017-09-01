
public class Gun : Ammunition
{
    private const double WeightFactor = 1.4;

    public Gun(string name)
        : base(name, WeightFactor)
    {
    }
}
