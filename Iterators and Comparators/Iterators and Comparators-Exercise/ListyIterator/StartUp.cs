namespace ListyIterator
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
            ListyIterator<string> myListy = null;

            //read the create command;
            var createCommand = Console.ReadLine()
                .Split(' ')
                .ToList();

            //check the create command and asign my listy;
            if (createCommand.Count == 1)
            {
                myListy = new ListyIterator<string>();
            }
            else
            {
                //var for list to create my listy;
                var list = createCommand.Skip(1).ToList();

                myListy = new ListyIterator<string>(list);
            }

            //read the commands;
            string command;

            while((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "HasNext":
                        Console.WriteLine(myListy.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(myListy.Move());
                        break;

                    case "Print":
                        try
                        {
                            myListy.Print();
                        }
                        catch(ArgumentException er)
                        {
                            Console.WriteLine(er.Message);
                        }
                        break;

                    case "PrintAll":
                        foreach (var item in myListy)
                        {
                            Console.Write($"{item} ");
                        }

                        Console.WriteLine();
                        break;
                }
            }//end of while loop;
        }
    }
}
