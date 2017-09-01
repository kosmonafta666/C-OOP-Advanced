
using System;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.BussinesLogic.Strategies
{
    public class RecycableGarbageDisposalStrategy : GarbageDisposalStrategy
    {
        public override double CalculateCapitalBalance(IWaste garbage)
        {
            double capitalEarned = garbage.Weight * 400;

            return capitalEarned;
        }

        public override double CalculateEnergyBalance(IWaste garbage)
        {
            double energyProduced = 0;

            double energyUsed = garbage.CalculateWasteVolume() * 0.5;

            return energyProduced - energyUsed;
        }
    }
}
