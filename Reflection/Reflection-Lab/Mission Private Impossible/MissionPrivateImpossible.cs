namespace Mission_Private_Impossible
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MissionPrivateImpossible
    {
        public static void Main(string[] args)
        {
            Spy spy = new Spy();

            var result = spy.RevealPrivateMethods("Hacker");

            Console.WriteLine(result);
        }
    }
}
