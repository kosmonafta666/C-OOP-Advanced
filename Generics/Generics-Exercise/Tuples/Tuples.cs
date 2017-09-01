namespace Tuples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tuples
    {
        public static void Main(string[] args)
        {
            //read the first input and print the tuple;
            var inputLine1 = Console.ReadLine()
                .Split(' ');

            var names = $"{inputLine1[0]} {inputLine1[1]}";

            Tuple<string, string, string> tp1 = new Tuple<string, string, string>
                (names, inputLine1[2], inputLine1[3]);

            Console.WriteLine(tp1);

            //read the second input and print the tuple;
            var inputLine2 = Console.ReadLine()
                .Split(' ');

            bool flag;

            if (inputLine2[2] == "drunk")
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            Tuple<string, int, bool> tp2 = new Tuple<string, int, bool>
                (inputLine2[0], int.Parse(inputLine2[1]), flag);

            Console.WriteLine(tp2);

            //read the third input and print the tuple;
            var inputLine3 = Console.ReadLine()
                .Split(' ');

            Tuple<string, double, string> tp3 = new Tuple<string, double, string>
                (inputLine3[0], double.Parse(inputLine3[1]), inputLine3[2]);

            Console.WriteLine(tp3);
        }
    }
}
