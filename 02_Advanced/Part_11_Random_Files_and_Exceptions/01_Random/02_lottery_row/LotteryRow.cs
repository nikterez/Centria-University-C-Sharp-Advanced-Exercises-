using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_lottery_row
{
    public class LotteryRow
    {
        private List<int> numbers;

        public LotteryRow()
        {
            this.RandomizeNumbers();
        }

        public List<int> Numbers()
        {
            return this.numbers;
        }

        public bool ContainsNumber(int number)
        {
            return this.numbers.Contains(number);
        }

        public void RandomizeNumbers()
        {
            this.numbers = new List<int>();

            Random lottery = new Random();

            while (true)
            {
                if (this.numbers.Count == 7)
                {
                    break;
                }

                int draw = lottery.Next(1, 41);

                if (ContainsNumber(draw))
                {
                    continue;
                }

                this.numbers.Add(draw);
            }

            this.numbers.Sort();
        }
    }
}
