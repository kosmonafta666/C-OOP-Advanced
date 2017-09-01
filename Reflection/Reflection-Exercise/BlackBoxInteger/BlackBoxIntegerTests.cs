namespace _02BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    class BlackBoxIntegerTests
    {
        static void Main(string[] args)
        {
            Type classType = typeof(BlackBoxInt);

            //create instance ob black box with default constructor;
            BlackBoxInt boxInstance = (BlackBoxInt)Activator.CreateInstance(classType, true);

            string inputLine;

            while((inputLine = Console.ReadLine()) != "END")
            {
                //split the input line;
                string[] tokens = inputLine.Split('_');
                //string for method name;
                string methodName = tokens[0];
                //int for value for mothod param;
                var value = int.Parse(tokens[1]);

                //find method and invoke with value;
                classType.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(boxInstance, new object[] { value });

                //find inner state of the black box instance;
                var innerState = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                    .First()
                    .GetValue(boxInstance)
                    .ToString();

                //print inner state;
                Console.WriteLine(innerState);

            }//end of while loop;
        }
    }
}
