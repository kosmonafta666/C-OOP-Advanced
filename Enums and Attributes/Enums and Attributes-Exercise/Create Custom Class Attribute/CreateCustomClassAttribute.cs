namespace Create_Custom_Class_Attribute
{
    using Create_Custom_Class_Attribute.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CreateCustomClassAttribute
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                //extract attributes of the weapon class;
                Type type = typeof(Weapon);

                object[] attr = type.GetCustomAttributes(false);
              
                var customAtr = (CustomAttribute)attr[0];

                //execute the command from the console;
                ExecuteCommand(command, customAtr);

                command = Console.ReadLine();
            }//end of while loop;

        }

        //method to print values of the custom attribute;
        private static void ExecuteCommand(string command, CustomAttribute attribute)
        {
            if (command == "Author")
            {
                Console.WriteLine($"Author: {attribute.Author}");
            }
            else if (command == "Revision")
            {
                Console.WriteLine($"Revision: {attribute.Revision}");
            }
            else if (command == "Description")
            {
                Console.WriteLine($"Class description: {attribute.Description}");
            }
            else if (command == "Reviewers")
            {
                Console.WriteLine($"Reviewers: {attribute.Reviewers}");
            }
        }
    }
}
