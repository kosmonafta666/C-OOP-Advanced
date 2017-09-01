namespace Birthday_Celebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BirthdayCelebrations
    {
        public static void Main(string[] args)
        {
            //list for IBirth entities;
            List<IBirth> creatures = new List<IBirth>();

            //read the subjects;
            string input;

            while((input = Console.ReadLine()) != "End")
            {
                //splited input;
                var tokens = input.Split(' ');

                //var for type of subject;
                var type = tokens[0];

                switch (type)
                {
                    case "Citizen":
                        //var for name of the citizen;
                        var name = tokens[1];
                        //var for age of the citizen;
                        var age = int.Parse(tokens[2]);
                        //var for id of the citizen;
                        var id = tokens[3];
                        //var for birth date of the citizen;
                        var birthDate = tokens[4];
                        //created citizen and add to creature list;
                        IBirth currentCitizen = new Human(name, age, id, birthDate);

                        creatures.Add(currentCitizen);
                        break;
                    case "Pet":
                        //asign the pet name;
                        name = tokens[1];
                        //asign the birth date of the pet;
                        birthDate = tokens[2];
                        //create the pet and add it to creature list;
                        IBirth currentPet = new Pet(name, birthDate);

                        creatures.Add(currentPet);
                        break;
                }

            }//end of while loop; 

            //read the match birth date;
            var matchBirthDate = Console.ReadLine();

            //list for creature with matched birth date;
            var matchedCreatures = creatures
                .Where(x => x.BirthDate.EndsWith(matchBirthDate))
                .ToList();

            //print the result;
            foreach (var creature in matchedCreatures)
            {
                Console.WriteLine(creature.BirthDate);
            }
        }
    }
}
