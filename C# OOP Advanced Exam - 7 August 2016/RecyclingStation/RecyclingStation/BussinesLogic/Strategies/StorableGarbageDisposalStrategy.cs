
using System;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.BussinesLogic.Strategies
{
    public class StorableGarbageDisposalStrategy : GarbageDisposalStrategy
    {
        public override double CalculateCapitalBalance(IWaste garbage)
        {
            double capitalEarned = 0;

            double capitalUsed = garbage.CalculateWasteVolume() * 0.65;

            return capitalEarned - capitalUsed;
        }

        public override double CalculateEnergyBalance(IWaste garbage)
        {
            double energyProduced = 0;

            double energyUsed = garbage.CalculateWasteVolume() * 0.13;

            return energyProduced - energyUsed;
        }
    }
}
