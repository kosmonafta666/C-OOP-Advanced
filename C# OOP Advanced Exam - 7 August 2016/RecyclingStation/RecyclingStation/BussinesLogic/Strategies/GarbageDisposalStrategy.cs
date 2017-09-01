
using System;
using RecyclingStation.WasteDisposal.Interfaces;
using RecyclingStation.BussinesLogic.Data;

namespace RecyclingStation.BussinesLogic.Strategies
{
    public abstract class GarbageDisposalStrategy : IGarbageDisposalStrategy
    {
        public abstract double CalculateEnergyBalance(IWaste garbage);

        public abstract double CalculateCapitalBalance(IWaste garbage);
         
        public IProcessingData ProcessGarbage(IWaste garbage)
        {
            double energyBalance = this.CalculateEnergyBalance(garbage);
            double capitalBalance = this.CalculateCapitalBalance(garbage);

            return new ProcessingData(energyBalance, capitalBalance);
        }
    }
}
