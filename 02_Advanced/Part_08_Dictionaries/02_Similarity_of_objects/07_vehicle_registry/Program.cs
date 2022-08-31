using System;
using System.Collections.Generic;

namespace Exercise_007_vehicle_registry
{
    class Program
    {
        static void Main(string[] args)
        {

            LicensePlate li1 = new LicensePlate("FI", "ABC-123");
            LicensePlate li2 = new LicensePlate("FI", "UXE-465");
            LicensePlate li3 = new LicensePlate("D", "B WQ-431");
            LicensePlate li4 = new LicensePlate("D", "B WQ-432");
            LicensePlate li5 = new LicensePlate("D", "B WQ-433");

            VehicleRegistry register = new VehicleRegistry();

            register.Add(li1, "Arto");
            register.Add(li2, "Arto");
            register.Add(li3, "Jurgen");
            register.Add(li4, "Jurgen");
            register.Add(li5, "Jurgen");

            Console.WriteLine("Plates:");
            register.PrintLicensePlates();
            System.Console.WriteLine("");

            Console.WriteLine("Owners:");
            register.PrintOwners();
            System.Console.WriteLine("");

            System.Console.WriteLine(li1 + " owner: " + register.Get(li1));
            System.Console.WriteLine(li2 + " owner: " + register.Get(li2));
            System.Console.WriteLine(li3 + " owner: " + register.Get(li3));

            System.Console.WriteLine("----");
            System.Console.WriteLine("");

            register.Remove(li1);
            register.Remove(li2);

            Console.WriteLine("Plates:");
            register.PrintLicensePlates();
            System.Console.WriteLine("");

            Console.WriteLine("Owners:");
            register.PrintOwners();
            System.Console.WriteLine("");

            System.Console.WriteLine(li1 + " owner: " + register.Get(li1));
            System.Console.WriteLine(li2 + " owner: " + register.Get(li2));
            System.Console.WriteLine(li3 + " owner: " + register.Get(li3));



        }
    }
}
