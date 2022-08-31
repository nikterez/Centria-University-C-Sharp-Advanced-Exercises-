using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_sort_the_cards
{
    public class Card:IComparable<Card>
    {
        public int value { get; }
        public Suit suit { get; }

        public Card(int value, Suit suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public override string ToString()
        {

            if (this.value == 11)
            {
                return suit + " J";
            }
            else if (this.value == 12)
            {
                return suit + " Q";
            }
            else if (this.value == 13)
            {
                return suit + " K";
            }
            else if (this.value == 14)
            {
                return suit + " A";
            }
            return suit + " " + this.value;
        }

        public int CompareTo(Card other)
        {
            if (this.value==other.value)
            {
                return this.suit.CompareTo(other.suit);
            }
            return this.value.CompareTo(other.value);
        }
    }
}