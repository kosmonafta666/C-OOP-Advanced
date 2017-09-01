
namespace RecyclingStation.BussinesLogic.Contracts.IO
{
    public interface IWriter
    {
        void GatherOutput(string outputToGather);

        void WriteGatheredOutput();
    }
}
