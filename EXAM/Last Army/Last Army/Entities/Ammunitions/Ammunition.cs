
using System;

public abstract class Ammunition : IAmmunition
{
    private string name;
    private double weight;
    private double wearLevel;

    public Ammunition(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public double Weight
    {
        get { return this.weight; }
        set { this.weight = value; }
    }

    public double WearLevel
    {
        get { return this.wearLevel; }
        set { this.wearLevel = value; }
    }

    public void DecreaseWearLevel(double wearAmount)
    {
        throw new NotImplementedException();
    }
}

