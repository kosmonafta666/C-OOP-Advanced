using RecyclingStation.BussinesLogic.Contracts.Core;
using RecyclingStation.BussinesLogic.Contracts.Factories;
using RecyclingStation.BussinesLogic.Contracts.IO;
using RecyclingStation.BussinesLogic.Core;
using RecyclingStation.BussinesLogic.Factories;
using RecyclingStation.BussinesLogic.IO;
using RecyclingStation.WasteDisposal;
using RecyclingStation.WasteDisposal.Interfaces;
using System;
using System.Collections.Generic;

namespace RecyclingStation
{
    public class RecyclingStationMain
    {
        public static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            Dictionary<Type, IGarbageDisposalStrategy> strategies = new Dictionary<Type, IGarbageDisposalStrategy>();
            IStrategyHolder strategyHolder = new StrategyHolder(strategies);
            IGarbageProcessor garbageProcessor = new GarbageProcessor(strategyHolder);
            IWasteFactory wasteFactory = new WasteFactory();
            IRecyclingStation recyclingStation = new RecyclingManager(garbageProcessor, wasteFactory);

            IEngine engine = new Engine(reader, writer, recyclingStation);

            engine.Run();
        }
    }
}
