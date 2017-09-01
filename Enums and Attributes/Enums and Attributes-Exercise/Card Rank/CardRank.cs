namespace Card_Rank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CardRank
    {
        public static void Main(string[] args)
        {
            var cards = Enum.GetValues(typeof(CardRanks));

            Console.WriteLine("Card Ranks:");

            foreach (var card in cards)
            {
                Console.WriteLine($"Ordinal value: {(int)card}; Name value: {card}");
            }
        }
    }
}
