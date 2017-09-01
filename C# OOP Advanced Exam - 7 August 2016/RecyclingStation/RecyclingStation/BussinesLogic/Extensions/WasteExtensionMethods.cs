
namespace RecyclingStation.WasteDisposal.Interfaces
{
    public static class WasteExtensionMethods
    {
        public static double CalculateWasteVolume(this IWaste waste)
        {
            return waste.VolumePerKg * waste.Weight;
        }
    }
}
