
using System;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.BussinesLogic.Strategies
{
    public class BurnableGarbageDisposalStrategy : GarbageDisposalStrategy
    {
        public override double CalculateCapitalBalance(IWaste garbage)
        {
            return 0;
        }

        public override double CalculateEnergyBalance(IWaste garbage)
        {
            double energyproduced = garbage.CalculateWasteVolume();

            double energyUsed = garbage.CalculateWasteVolume() * 0.20;

            return energyproduced - energyUsed;
        }
    }
}
