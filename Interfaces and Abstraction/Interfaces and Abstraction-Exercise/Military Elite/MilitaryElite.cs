namespace Military_Elite
{
    using Military_Elite.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MilitaryElite
    {
        private static IList<ISoldier> army;

        public static void Main()
        {
            army = new List<ISoldier>();

            //read the input;
            string input;
            
            while((input = Console.ReadLine()) != "End")
            {
                //split the input;
                var args = input.Split();

                switch(args[0])
                {
                    case "Private":
                        army.Add(new Private(args[1], args[2], args[3], double.Parse(args[4])));
                        break;
                    case "Spy":
                        army.Add(new Spy(args[1], args[2], args[3], int.Parse(args[4])));
                        break;
                    case "LeutenantGeneral":
                        var privates = ExtractPrivates(args.Skip(5).ToList());
                        army.Add(new LeutenantGeneral(args[1], args[2], args[3], double.Parse(args[4]), privates));
                        break;
                    case "Commando":
                        if (args[5] != "Airforces" && args[5] != "Marines")
                        {
                            break;
                        }

                        var missions = ExtractMissions(args.Skip(6).ToList());
                        army.Add(new Commando(args[1], args[2], args[3], double.Parse(args[4]), args[5], missions));
                        break;
                    case "Engineer":
                        if (args[5] != "Airforces" && args[5] != "Marines")
                        {
                            break;
                        }

                        var parts = ExtractParts(args.Skip(6).ToList());
                        army.Add(new Engineer(args[1], args[2], args[3], double.Parse(args[4]), args[5], parts));
                        break;

                }
            }//end of while loop;

            foreach (var soldier in army)
            {
                Console.WriteLine(soldier);
            }
        }

        //method to add repairs to engineer;
        private static IList<IRepair> ExtractParts(IList<string> parts)
        {
            var list = new List<IRepair>();

            for (int i = 0; i < parts.Count - 1; i += 2)
            {
                list.Add(new Repair(parts[i], int.Parse(parts[i + 1])));
            }

            return list;
        }

        //method to add missions to commando from input;
        private static IList<IMission> ExtractMissions(IList<string> missions)
        {
            var list = new List<IMission>();

            for (int i = 0; i < missions.Count - 1; i += 2)
            {
                if (missions[i + 1] != "inProgress" && missions[i + 1] != "Finished")
                {
                    continue;
                }

                list.Add(new Mission(missions[i], missions[i + 1]));
            }

            return list;
        }

        //method to extract from privates from input;
        private static IList<ISoldier> ExtractPrivates(IList<string> soldiers)
        {
            var list = new List<ISoldier>();

            foreach (var soldier in soldiers)
            {
                list.Add(army.First(x => x.Id == soldier));
            }

            return list;
        }
    }
}
