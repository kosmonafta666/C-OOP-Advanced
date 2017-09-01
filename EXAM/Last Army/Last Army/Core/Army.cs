
using System;
using System.Collections.Generic;

public class Army : IArmy
{
    public Army()
    {
        this.Soldiers = new List<ISoldier>();
    }

    public IReadOnlyList<ISoldier> Soldiers
    {
        get;
    }

    public void AddSoldier(ISoldier soldier)
    {
        throw new NotImplementedException();
    }

    public void RegenerateTeam(string soldierType)
    {
        throw new NotImplementedException();
    }
}

