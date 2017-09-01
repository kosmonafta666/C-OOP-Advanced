
using System;

public abstract class Mission : IMission
{
    private string name;
    private double enduranceRequired;
    private double scoreToComplete;
    private double wearLevelDecrement;

    public Mission(double enduranceRequired, double scopeToComplete)
    {
        this.EnduranceRequired = enduranceRequired;
        this.ScoreToComplete = scopeToComplete;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public double EnduranceRequired
    {
        get { return this.enduranceRequired; }
        set { this.enduranceRequired = value; }
    }

    public double ScoreToComplete
    {
        get { return this.scoreToComplete; }
        set { this.scoreToComplete = value; }
    }

    public double WearLevelDecrement
    {
        get { return this.wearLevelDecrement; }
        set { this.wearLevelDecrement = value; }
    }
}

