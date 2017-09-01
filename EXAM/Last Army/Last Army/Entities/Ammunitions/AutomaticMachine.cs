public class AutomaticMachine : Ammunition
{
    private const double WeightFactor = 6.3;

    public AutomaticMachine(string name)
        : base(name, WeightFactor)
    {
    }
}