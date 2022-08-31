using System;

namespace _04_sensors_and_temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardSensor ten = new StandardSensor(10);
            StandardSensor minusFive = new StandardSensor(-5);

            Console.WriteLine(ten.Read());
            Console.WriteLine(minusFive.Read());

            Console.WriteLine(ten.IsOn());
            ten.SetOff();
            Console.WriteLine(ten.IsOn());

            System.Console.WriteLine("-- -- --");

            TemperatureSensor temperatureSensor = new TemperatureSensor();
            temperatureSensor.SetOn();
            Console.WriteLine(temperatureSensor.Read());
        }
    }
}
