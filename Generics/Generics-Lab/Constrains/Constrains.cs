namespace Constrains
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Constrains
    {
        public static void Main(string[] args)
        {
            Scale<int> scale = new Scale<int>(5, 67);
            Scale<string> scale1 = new Scale<string>("S", "A");

            Console.WriteLine(scale1.GetHavier());
        }
    }
}
