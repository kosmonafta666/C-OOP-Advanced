namespace Card_Power.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Card : IComparable<Card>
    {
        private Rank rank;
        private Suit suit;

        public Rank Rank
        {
            get { return this.rank; }
            private set { this.rank = value; }
        }

        public Suit Suit
        {
            get { return this.suit; }
            private set { this.suit = value; }
        }

        public int Power
        {
            get { return (int)this.Rank + (int)this.Suit; }
        }

        public string Name
        {
            get { return $"{this.Rank} of {this.Suit}"; }
        }

        public Card (string rank, string suit)
        {
            this.Rank = (Rank)Enum.Parse(typeof(Rank), rank);
            this.Suit = (Suit)Enum.Parse(typeof(Suit), suit);
        }

        public override string ToString()
        {
            return $"Card name: {this.Name}; Card power: {this.Power}";
        }

        public int CompareTo(Card other)
        {
            var result = this.Power.CompareTo(other.Power);

            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Card card = obj as Card;

            return this.Power.Equals(card.Power);
        }
    }
}
