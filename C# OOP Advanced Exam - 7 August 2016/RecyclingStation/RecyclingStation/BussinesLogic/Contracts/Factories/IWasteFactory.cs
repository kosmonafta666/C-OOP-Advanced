
using RecyclingStation.WasteDisposal.Interfaces;

namespace RecyclingStation.BussinesLogic.Contracts.Factories
{
    public interface IWasteFactory
    {
        IWaste Create(string name, double weight, double volumePerKg, string type);
    }
}
