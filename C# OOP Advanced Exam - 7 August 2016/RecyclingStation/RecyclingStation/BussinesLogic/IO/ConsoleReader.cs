
using System;
using RecyclingStation.BussinesLogic.Contracts.IO;

namespace RecyclingStation.BussinesLogic.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
