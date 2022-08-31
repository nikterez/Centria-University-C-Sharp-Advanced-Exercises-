using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_taco_boxes
{
    public class CustomTacoBox : ITacoBox
    {
        public int tacos;

        public CustomTacoBox(int tacos)
        {
            this.tacos = tacos;
        }

        public void Eat()
        {
            if (0 < this.tacos)
            {
                this.tacos--;
            }
        }

        public int TacosRemaining()
        {
            return this.tacos;
        }

    }
}