namespace Card_Power
{
    using Card_Power.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CardPower
    {
        public static void Main(string[] args)
        {
            Game();
        }

        //method to read card;
        public static Card ReadCard()
        {
            //read the rank of card;
            var rank = Console.ReadLine();
            //read the suit of card;
            var suit = Console.ReadLine();

            //create card;
            var card = new Card(rank, suit);

            return card;
        }

        public static void PrintAttributes()
        {
            var input = Console.ReadLine();

            if (input == "Rank")
            {
                PrintAttributes(typeof(Rank));
            }
            else
            {
                PrintAttributes(typeof(Suit));
            }
        }

        public static void PrintAttributes(Type type)
        {
            var attributes = type.GetCustomAttributes(false);

            Console.WriteLine(attributes[0]);
        }

        //method that prints all cards;
        public static void PrintDeck()
        {
            var deck = GenerateDeck();

            foreach (var card in deck)
            {
                Console.WriteLine(card.Name);
            }
        }

        //method that generates all cards;
        public static List<Card> GenerateDeck()
        {
            var deck = new List<Card>();

            foreach (var suit in Enum.GetNames(typeof(Suit)))
            {
                foreach (var rank in Enum.GetNames(typeof(Rank)))
                {
                    deck.Add(new Card(rank, suit));
                }
            }

            return deck;
        }

        //method for game of cards for two players;
        public static void Game()
        {
            var firstPlayer = Console.ReadLine();
            var secondPlayer = Console.ReadLine();

            List<Card> deck = GenerateDeck();

            var firstDeck = new List<Card>();
            var secondDeck = new List<Card>();

            Card biggest;

            string winner = firstPlayer;

            while (firstDeck.Count != 5 || secondDeck.Count != 5)
            {
                var inputArgs = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    var card = new Card(inputArgs[0], inputArgs[2]);

                    if (deck.Contains(card))
                    {
                        deck.Remove(card);

                        if (firstDeck.Count < 5)
                        {
                            firstDeck.Add(card);
                        }
                        else
                        {
                            secondDeck.Add(card);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                }
                catch (Exception er)
                {
                    Console.WriteLine("No such card exists.");
                }
            }

            int firstMax = firstDeck.Max(x => x.Power);
            
            int secondMax = secondDeck.Max(x => x.Power);

            if (firstMax > secondMax)
            {
                biggest = firstDeck.Where(x => x.Power == firstMax).FirstOrDefault();
                Console.WriteLine($"{firstPlayer} wins with {biggest.Name}.");
            }
            else
            {
                biggest = secondDeck.Where(x => x.Power == secondMax).FirstOrDefault();
                Console.WriteLine($"{secondPlayer} wins with {biggest.Name}.");
            }
        }
    }
}
