using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_sensors_and_temperature
{
    public class StandardSensor:ISensor
    {
        private int temp;

        private bool on;

        public StandardSensor(int temp)
        {
            this.temp=temp;
            this.on=true;
        }

        public int Read()
        {
            return this.temp;
        }

        public bool IsOn()
        {
            return on;
        }

        public void SetOn()
        {

        }
           
        public void SetOff()
        {

        }
    }
}