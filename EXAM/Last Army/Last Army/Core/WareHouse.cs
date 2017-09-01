
using System;
using System.Collections.Generic;

public class WareHouse : IWareHouse
{
    public WareHouse()
    {
        this.WearHouse = new Dictionary<string, List<Ammunition>>();
    }

    public Dictionary<string, List<Ammunition>> WearHouse
    {
        get; set;
    }

    public void EquipArmy(IArmy army)
    {
        throw new NotImplementedException();
    }
}

