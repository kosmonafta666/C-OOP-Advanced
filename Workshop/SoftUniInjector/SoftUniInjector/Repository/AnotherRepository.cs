
using System;

namespace SoftUniInjector.Repository
{
    public class AnotherRepository : IAnotherRepository
    {
        public void AndMe()
        {
            Console.WriteLine($"I was added later, and app should work too.");
        }
    }
}
