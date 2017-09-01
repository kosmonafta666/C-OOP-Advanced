namespace Card_Suit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CardSuit
    {
        public static void Main(string[] args)
        {
            Array cards = Enum.GetValues(typeof(CardSuits));

            Console.WriteLine("Card Suits:");

            foreach (var card in cards)
            {
                Console.WriteLine($"Ordinal value: {(int)card}; Name value: {card}");
            }
        }
    }
}
