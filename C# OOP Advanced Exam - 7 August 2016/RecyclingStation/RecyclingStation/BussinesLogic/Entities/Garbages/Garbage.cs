
using System;
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.BussinesLogic.Entities.Garbages
{
    public abstract class Garbage : IWaste
    {
        private string name;
        private double volumePerKg;
        private double weight;

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public double VolumePerKg
        {
            get => this.volumePerKg;
            private set => this.volumePerKg = value;
        }

        public double Weight
        {
            get => this.weight;
            set => this.weight = value;
        }

        public Garbage(string name, double weight, double volumePerKg)
        {
            this.Name = name;
            this.Weight = weight;
            this.VolumePerKg = volumePerKg;
        }
    }
}
