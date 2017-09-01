namespace Custom_List
{
    using Custom_List.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CustomList
    {
        public static void Main(string[] args)
        {
            //read the input string;
            string inputString;

            IGenericList<string> myList = new GenericList<string>();

            while((inputString = Console.ReadLine()) != "END")
            {
                //var for splitted input line;
                var tokens = inputString.Split(' ');

                switch (tokens[0])
                {
                    case "Add":
                        myList.Add(tokens[1]);
                        break;

                    case "Remove":
                        myList.Remove(int.Parse(tokens[1]));
                        break;

                    case "Contains":
                        Console.WriteLine(myList.Contains(tokens[1]));
                        break;

                    case "Swap":
                        myList.Swap(int.Parse(tokens[1]), int.Parse(tokens[2]));
                        break;

                    case "Greater":
                        Console.WriteLine(myList.CountGreaterThan(tokens[1]));
                        break;

                    case "Max":
                        Console.WriteLine(myList.Max());
                        break;

                    case "Min":
                        Console.WriteLine(myList.Min());
                        break;

                    case "Print":
                        foreach (var item in myList)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case "Sort":
                        myList = Sorted.Sort<string>(myList);
                        break;
                }
            }//end of while loop;
        }


    }
}
