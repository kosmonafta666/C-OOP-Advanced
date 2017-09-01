
using RecyclingStation.BussinesLogic.Attributes;
using RecyclingStation.BussinesLogic.Strategies;

namespace RecyclingStation.BussinesLogic.Entities.Garbages
{
    [StorableStrategy(typeof(StorableGarbageDisposalStrategy))]
    public class StorableGarbage : Garbage
    {
        public StorableGarbage(string name, double weight, double volumePerKg)
            : base(name, weight, volumePerKg)
        {
        }
    }
}
