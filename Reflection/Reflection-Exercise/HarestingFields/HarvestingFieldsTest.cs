namespace _01HarestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    class HarvestingFieldsTest
    {
        static void Main(string[] args)
        {
            Type classType = typeof(HarvestingFields);

            FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static
                | BindingFlags.NonPublic | BindingFlags.Public);

            //array for reguested fields;
            FieldInfo[] gatheredFields = null;

            string command;

            while((command = Console.ReadLine()) != "HARVEST")
            {
                switch (command)
                {
                    case "protected":
                        gatheredFields = fields.Where(x => x.IsFamily).ToArray();
                        break;
                    case "private":
                        gatheredFields = fields.Where(x => x.IsPrivate).ToArray();
                        break;
                    case "public":
                        gatheredFields = fields.Where(x => x.IsPublic).ToArray();
                        break;
                    case "all":
                        gatheredFields = fields;
                        break;
                }

                //array of the reguested fields;
                string[] result = gatheredFields
                    .Select(x => $"{x.Attributes.ToString().ToLower()} {x.FieldType.Name} {x.Name}")
                    .ToArray();

                //print the result;
                Console.WriteLine(string.Join(Environment.NewLine, result).Replace("family", "protected"));

            }//end of while loop;          
        }
    }
}
