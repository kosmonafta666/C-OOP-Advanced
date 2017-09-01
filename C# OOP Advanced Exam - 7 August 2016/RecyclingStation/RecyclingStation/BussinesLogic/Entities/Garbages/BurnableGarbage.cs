
using RecyclingStation.BussinesLogic.Attributes;
using RecyclingStation.BussinesLogic.Strategies;

namespace RecyclingStation.BussinesLogic.Entities.Garbages
{
    [BurnableStrategy(typeof(BurnableGarbageDisposalStrategy))]
    public class BurnableGarbage : Garbage
    {
        public BurnableGarbage(string name, double weight, double volumePerKg) 
            : base(name, weight, volumePerKg)
        {
        }
    }
}
