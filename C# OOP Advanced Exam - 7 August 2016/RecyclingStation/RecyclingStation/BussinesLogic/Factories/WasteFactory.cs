
using RecyclingStation.BussinesLogic.Contracts.Factories;
using RecyclingStation.WasteDisposal.Interfaces;
using System;
using System.Linq;
using System.Reflection;

namespace RecyclingStation.BussinesLogic.Factories
{
    public class WasteFactory : IWasteFactory
    {
        private const string GarbageSuffix = "Garbage";

        public IWaste Create(string name, double weight, double volumePerKg, string type)
        {
            var fullTypeType = String.Format($"{type}{GarbageSuffix}");

            Type typeOfGarbageToActivate = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.Equals(fullTypeType, StringComparison.OrdinalIgnoreCase));

            object[] typeArgs = new object[]
            {
                name,
                weight,
               volumePerKg
            };

            IWaste waste = (IWaste)Activator.CreateInstance(typeOfGarbageToActivate, typeArgs);

            return waste;
        }
    }
}
