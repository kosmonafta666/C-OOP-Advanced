namespace Kings_Gambit
{
    using Kings_Gambit.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class KingsGambit
    {
        public static void Main(string[] args)
        {
            //list for all soldiers;
            var soldiers = new List<Soldier>();

            //read the king and create it;
            var kingName = Console.ReadLine();

            var king = new King(kingName);

            //read the royal guards, create it, add to soldier and attach to king attack event;
            var royalGuards = Console.ReadLine()
                .Split(' ')
                .ToList();

            foreach (var guardName in royalGuards)
            {
                var currentGuard = new RoyalGuard(guardName);

                soldiers.Add(currentGuard);

                king.UnderAttack += currentGuard.KingUnderAttack;
            }

            //read the footman, create it, add to soldier and attach to king attack event;
            var footMans = Console.ReadLine()
                .Split(' ')
                .ToList();

            foreach (var footName in footMans)
            {
                var currentFootMan = new Footman(footName);

                soldiers.Add(currentFootMan);

                king.UnderAttack += currentFootMan.KingUnderAttack;
            }

            //read the commands;
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                //solit ther command;
                var token = command.Split(' ');

                switch (token[0])
                {
                    case "Kill":
                        var soldierToRemove = soldiers.FirstOrDefault(x => x.Name == token[1]);
                        king.UnderAttack -= soldierToRemove.KingUnderAttack;
                        soldiers.Remove(soldierToRemove);
                        break;
                    case "Attack":
                        king.OnUnderAttack();
                        break;                    
                }
            }
        }
    }
}
