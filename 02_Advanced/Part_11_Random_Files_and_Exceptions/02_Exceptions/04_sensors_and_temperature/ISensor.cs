using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_sensors_and_temperature
{
    public interface ISensor
    {
        bool IsOn();    // returns true if the sensor is on
        void SetOn();      // sets the sensor on
        void SetOff();     // sets the sensor off
        int Read();        // returns the value of the sensor if it's on
                           // if the sensor is not on throw a IllegalStateException
    }
}