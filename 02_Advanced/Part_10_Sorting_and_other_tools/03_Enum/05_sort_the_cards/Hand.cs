using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_sort_the_cards
{
    public class Hand:IComparable<Hand>
    {
        private List<Card> cardList = new List<Card>();

        public void Add(Card card)
        {
            this.cardList.Add(card);
        }

        public void Print()
        {
            this.cardList.ForEach(System.Console.WriteLine);
        }

        public void Sort()
        {
            this.cardList.Sort();
        }

        public int CompareTo(Hand other)
        {
            int sum=0;
            int xSum=0;
            
            foreach (var card in this.cardList)
            {
                sum+=card.value;
            }

            foreach (var card in other.cardList)
            {
                xSum+=card.value;
            }

            return sum.CompareTo(xSum);
            //return this.cardList.Sum(i=>i.value).CompareTo(other.cardList.Sum(i=>i.value));

        }


    }
}