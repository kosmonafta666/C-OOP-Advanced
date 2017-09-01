namespace Stealer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Stealer
    {
        public static void Main(string[] args)
        {
            Spy spy = new Spy();

            var result = spy.StealFieldInfo("Hacker", "username", "password");

            Console.WriteLine(result);
        }
    }
}
