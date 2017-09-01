namespace Card_Power.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TypeAttribute("Suit", "Provides suit constants for a Card class.")]
    public enum Suit
    {
        Clubs = 0,
        Diamonds = 13,
        Hearts = 26,
        Spades = 39
    }
}
