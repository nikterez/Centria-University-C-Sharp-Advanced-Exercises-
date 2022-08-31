using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_sensors_and_temperature
{

    public class TemperatureSensor:ISensor
    {
        private int temp;
        private bool on;

        public TemperatureSensor()
        {
            this.on=false;
        }
        public int Read()
        {

            if(!IsOn())
            {
                throw new InvalidOperationException();
            }

            Random tempGen = new Random();
            this.temp = tempGen.Next(-30,31);
            return this.temp;
        
        }

        public bool IsOn()
        {
            return on;
        }

        public void SetOn()
        {
            this.on=true;
        }

        public void SetOff()
        {
            this.on=false;
        }
    }
}