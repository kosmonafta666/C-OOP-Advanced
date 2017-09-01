namespace Dependency_Inversion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //create primitive calculator object;
            var myCalc = new PrimitiveCalculator();

            //read the commands;
            string command;

            while((command = Console.ReadLine()) != "End")
            {
                //split the command;
                var tokens = command.Split(' ').ToList();

                //check if change the strategy and calculate the result;
                if (tokens[0] == "mode")
                {
                    myCalc.changeStrategy(char.Parse(tokens[1]));
                }
                else
                {
                    var result = myCalc.performCalculation(int.Parse(tokens[0]), int.Parse(tokens[1]));

                    Console.WriteLine(result);
                }
            }//end of while loop;
        }
    }
}
