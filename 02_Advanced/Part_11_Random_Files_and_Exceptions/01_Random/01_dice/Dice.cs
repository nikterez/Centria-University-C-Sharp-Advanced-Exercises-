using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_dice
{
    public class Dice
    {
        private Random random;
        private int numberOfFaces;

        public Dice(int numberOfFaces)
        {
            this.random = new Random();
            this.numberOfFaces=numberOfFaces;
        }
        public int ThrowDie()
        {
            int roll = random.Next(1,numberOfFaces+1);
            return roll;
        }
    }
}