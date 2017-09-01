
using RecyclingStation.BussinesLogic.Contracts.Core;
using RecyclingStation.BussinesLogic.Contracts.Factories;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.BussinesLogic.Core
{
    class RecyclingManager : IRecyclingStation
    {
        private IGarbageProcessor garbageProcessor;
        private IWasteFactory wasteFactory;

        private double capitalBalance;
        private double energyBalance;

        private double minimumEnergyBalance;
        private double minimumCapitalBalance;
        private string typeOfGarbage;

        private bool requirimentsAreSet;

        public RecyclingManager(IGarbageProcessor garbageProcessor, IWasteFactory wasteFactory)
        {
            this.garbageProcessor = garbageProcessor;
            this.wasteFactory = wasteFactory;
        }

        public string ChangeManagementRequirement(double minimumEnergyBalance, double minimumCapitalBalance,
            string typeOfGarbage)
        {
            this.minimumEnergyBalance = minimumEnergyBalance;
            this.minimumCapitalBalance = minimumCapitalBalance;
            this.typeOfGarbage = typeOfGarbage;

            this.requirimentsAreSet = true;

            return $"Management requirement changed!";
        }

        public string ProcessGarbage(string name, double weight, double volumePerKg, string type)
        {
            if (this.requirimentsAreSet)
            {
                bool requirementsAreSatisfied = true;

                if (this.typeOfGarbage == type)
                {
                    requirementsAreSatisfied = this.energyBalance >= this.minimumEnergyBalance &&
                        this.capitalBalance >= this.minimumCapitalBalance;
                }

                if (!requirementsAreSatisfied)
                {
                    return $"Processing Denied!";
                }
            }

            IWaste waste = this.wasteFactory.Create(name, weight, volumePerKg, type);

            IProcessingData processData = this.garbageProcessor.ProcessWaste(waste);

            this.capitalBalance += processData.CapitalBalance;
            this.energyBalance += processData.EnergyBalance;

            return $"{waste.Weight:f2} kg of {waste.Name} successfully processed!";
        }

        public string Status()
        {
            return $"Energy: {this.energyBalance:f2} Capital: {this.capitalBalance:f2}";
        }
    }
}
