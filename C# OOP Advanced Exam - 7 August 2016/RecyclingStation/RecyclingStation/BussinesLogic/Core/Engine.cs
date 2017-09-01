
using System;
using RecyclingStation.BussinesLogic.Contracts.Core;
using RecyclingStation.BussinesLogic.Contracts.IO;
using System.Reflection;
using System.Linq;

namespace RecyclingStation.BussinesLogic.Core
{
    public class Engine : IEngine
    {
        private const string TermanedCommand = "TimeToRecycle";

        private IReader reader;
        private IWriter writer;
        private IRecyclingStation recyclingStation;
        private readonly MethodInfo[] RecyclingStationMethods;

        private IReader Reader
        {
            get { return this.reader; }
            set { this.reader = value; }
        }

        private IWriter Writer
        {
            get { return this.writer; }
            set { this.writer = value; }
        }

        public IRecyclingStation RecyclingStation
        {
            get => this.recyclingStation;
            set => this.recyclingStation = value;
        }

        public Engine(IReader reader, IWriter writer, IRecyclingStation recyclingStation)
        {
            this.Reader = reader;
            this.Writer = writer;
            this.RecyclingStation = recyclingStation;

            this.RecyclingStationMethods = this.RecyclingStation.GetType().GetMethods();
        }

        private string[] SplitStringByChar(string toSplit, params char[] charsToSplit)
        {
            return toSplit.Split(charsToSplit, StringSplitOptions.RemoveEmptyEntries);
        }

        public void Run()
        {
            string inputLine;

            while((inputLine = this.Reader.ReadLine()) != TermanedCommand)
            {
                string[] commandArgs = this.SplitStringByChar(inputLine, ' ');

                var methodName = commandArgs[0];

                var methodNonParsedParams = default(string[]);

                if (commandArgs.Length == 2)
                {
                    methodNonParsedParams = this.SplitStringByChar(commandArgs[1], '|');
                }               

                MethodInfo methodToInvoke = this.RecyclingStationMethods
                    .FirstOrDefault(x => x.Name.Equals(methodName, StringComparison.OrdinalIgnoreCase));

                var methodParams = methodToInvoke.GetParameters();

                object[] parsedParams = new object[methodParams.Length];

                for (int i = 0; i < methodParams.Length; i++)
                {
                    Type currentParamType = methodParams[i].ParameterType;

                    parsedParams[i] = Convert.ChangeType(methodNonParsedParams[i], currentParamType);
                }

                object result = methodToInvoke.Invoke(this.RecyclingStation, parsedParams);

                this.Writer.GatherOutput(result.ToString());               
            }

            this.Writer.WriteGatheredOutput();
        }
    }
}
