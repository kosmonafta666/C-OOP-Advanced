
using System;
using RecyclingStation.BussinesLogic.Contracts.IO;
using System.Text;

namespace RecyclingStation.BussinesLogic.IO
{
    public class ConsoleWriter : IWriter
    {
        private StringBuilder outputGatherer;

        public StringBuilder OutputGatherer
        {
            get { return this.outputGatherer; }
            private set { this.outputGatherer = value; }
        }

        public ConsoleWriter(StringBuilder outputGatherer)
        {
            this.OutputGatherer = outputGatherer;
        }

        public ConsoleWriter()
            : this(new StringBuilder())
        {
        }

        public void GatherOutput(string outputToGather)
        {
            this.OutputGatherer.AppendLine(outputToGather);
        }

        public void WriteGatheredOutput()
        {
            Console.Write(this.OutputGatherer.ToString());
        }
    }
}
