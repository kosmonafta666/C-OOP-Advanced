
using System;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.BussinesLogic.Data
{
    public class ProcessingData : IProcessingData
    {
        private double energyBalance;
        private double capitalBalance;

        public double EnergyBalance
        {
            get => energyBalance;
            set => energyBalance = value;
        }

        public double CapitalBalance
        {
            get => capitalBalance;
            set => capitalBalance = value;
        }

        public ProcessingData(double energyBalance, double capitalBalance)
        {
            this.EnergyBalance = energyBalance;
            this.CapitalBalance = capitalBalance;
        }
    }
}
