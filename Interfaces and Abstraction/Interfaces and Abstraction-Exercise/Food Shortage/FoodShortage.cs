namespace Food_Shortage
{
    using Food_Shortage.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;  


    public class FoodShortage
    {
        public static void Main(string[] args)
        {
            //list for all humans;
            List<Human> humans = new List<Human>();

            //var for number of humans;
            var n = int.Parse(Console.ReadLine());


            //reading the humans;
            for (int i = 1; i <= n; i++)
            {
                //var for human info;
                var humanInfo = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (humanInfo.Length > 3)
                {
                    //var for citizen name;
                    var citizenName = humanInfo[0];
                    //var for citizen age;
                    var citizenAge = int.Parse(humanInfo[1]);
                    //var for citizen id;
                    var citizenId = humanInfo[2];
                    //var for citizen birthdate;
                    var citizenBirthDate = humanInfo[3];

                    //var for citizen;
                    var citizen = new Citizen(citizenName, citizenAge, citizenId, citizenBirthDate);

                    //add citizen to human list;
                    humans.Add(citizen);
                }
                else if (humanInfo.Length == 3)
                {
                    //var for rebel name;
                    var rebelName = humanInfo[0];
                    //var for rebel age;
                    var rebelAge = int.Parse(humanInfo[1]);
                    //var for rebel group;
                    var rebelGroup = humanInfo[2];

                    //var for rebel;
                    var rebel = new Rebel(rebelName, rebelAge, rebelGroup);

                    //add rebel to humans;
                    humans.Add(rebel);
                }
            }//end of reading the humans;

            //var for reading the person who buy food;
            var buyer = Console.ReadLine();

            while (buyer != "End")
            {
                //find the human and buy a food;
                if (humans.Find(x => x.Name == buyer) != null)
                {
                    humans.FirstOrDefault(x => x.Name == buyer).BuyFood();
                }
                
                buyer = Console.ReadLine();
            }//end of bying the food;

            //print the result;
            Console.WriteLine(humans.Sum(x => x.Food));
        } 
    }
}
