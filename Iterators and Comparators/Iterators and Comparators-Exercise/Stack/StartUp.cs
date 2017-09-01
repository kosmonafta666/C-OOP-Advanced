namespace Stack
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
            //create generic custom stack;
            var myStack = new Stack<int>();

            //read the operation;
            string inputString;

            while((inputString = Console.ReadLine()) != "END")
            {
                //split the input string;
                var tokens = inputString.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                switch(tokens[0])
                {
                    case "Push":
                        for (int i = 1; i < tokens.Length; i++)
                        {
                            myStack.Push(int.Parse(tokens[i]));
                        }
                        break;

                    case "Pop":
                        try
                        {
                            myStack.Pop();
                        }
                        catch (InvalidOperationException er)
                        {
                            Console.WriteLine(er.Message);
                        }
                        break;
                }
            }//end of while loop;


            //print the custom stack;
            for (int i = 1; i <= 2; i++)
            {
                foreach (var element in myStack)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
