using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter10
{
    public class Card
    {
        public readonly Rank rank;
        public readonly Suit suit;

        private Card()
        {
            // throw new System.NotImplementedException();
        }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public override string ToString()
        {
            return "The" + rank + " of " + suit + "s";
        }
    }
}   