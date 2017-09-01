
using System.Collections.Generic;

public interface IWareHouse
{
    Dictionary<string, List<Ammunition>> WearHouse { get; }

    void EquipArmy(IArmy army);
}

