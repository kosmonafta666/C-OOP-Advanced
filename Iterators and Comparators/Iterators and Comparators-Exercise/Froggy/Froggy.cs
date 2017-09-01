namespace Froggy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Froggy
    {
        public static void Main(string[] args)
        {
            //read the stones;
            var stones = Console.ReadLine()
                .Split(new[] { ',' , ' '}, StringSplitOptions.RemoveEmptyEntries)

                .Select(int.Parse)
                .ToArray();

            //create custom lake;
            var lake = new Lake(stones);

            //print the result;
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
