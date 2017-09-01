namespace Collector
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Collector
    {
        public static void Main(string[] args)
        {
            Spy spy = new Spy();

            var result = spy.CollectGettersAndSetters("Hacker");

            Console.WriteLine(result);
        }
    }
}
