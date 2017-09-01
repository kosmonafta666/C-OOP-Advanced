
using RecyclingStation.BussinesLogic.Attributes;
using RecyclingStation.BussinesLogic.Strategies;

namespace RecyclingStation.BussinesLogic.Entities.Garbages
{
    [RecyclableStrategy(typeof(RecycableGarbageDisposalStrategy))]
    public class RecyclableGarbage : Garbage
    {
        public RecyclableGarbage(string name, double weight, double volumePerKg)
            : base(name, weight, volumePerKg)
        {
        }
    }
}
