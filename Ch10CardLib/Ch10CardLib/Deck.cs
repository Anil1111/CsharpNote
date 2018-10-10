using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter10
{
    public class Deck
    {
        private Card[] cards;

        public Deck()
        {
            // throw new System.NotImplementedException();
            cards = new Card[52];
            for (int suitVal = 0; suitVal<4;++suitVal)
            {
                for(int rankVal=1;rankVal<14;++rankVal)
                {
                    cards[suitVal + 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
                }
            }
        }

        public Card GetCard(int cardNum)
        {
            // throw new System.NotImplementedException();
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw new System.ArgumentOutOfRangeException("carNum", cardNum, "Value must be between 0 and 51.");
        }

        public void Shuffle()
        {
            // throw new System.NotImplementedException();

        }
    }
}