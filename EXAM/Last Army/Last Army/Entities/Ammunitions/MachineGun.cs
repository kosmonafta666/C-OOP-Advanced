
public class MachineGun : Ammunition
{
    private const double WeightFactor = 10.6;

    public MachineGun(string name)
        : base(name, WeightFactor)
    {
    }
}
