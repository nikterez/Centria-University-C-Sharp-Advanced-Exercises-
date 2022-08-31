using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_007_vehicle_registry
{
    public class VehicleRegistry
    {
        private Dictionary<LicensePlate, string> vRegistry;


        public VehicleRegistry()
        {
            this.vRegistry = new Dictionary<LicensePlate, string>();
        }

        public bool Add(LicensePlate licensePlate, string owner)
        {
            if (this.vRegistry.ContainsKey(licensePlate))
            {
                return false;
            }
            else
            {
                this.vRegistry.Add(licensePlate, owner);
                return true;
            }
        }

        public bool Remove(LicensePlate licensePlate)
        {
            if(this.vRegistry.ContainsKey(licensePlate))
            {
                this.vRegistry.Remove(licensePlate);
                return true;
            }
            return false;
        }

        public string Get(LicensePlate licensePlate)
        {   
            if(this.vRegistry.ContainsKey(licensePlate))
            {
                return this.vRegistry[licensePlate];
            }
            else
            {
                return "Car not in registry";
            }
        }

        public void PrintLicensePlates()
        {
            foreach (var item in this.vRegistry)
            {
                System.Console.WriteLine(item.Key.ToString());
            }

        }

        public void PrintOwners()
        {   
            
            // LINQ
            // foreach (var item in this.vRegistry.Values.Distinct())
            // {
            //     System.Console.WriteLine(item);
            // }
    
            List<string> owners = new List<string>();
            foreach (var item in this.vRegistry)
            {
                if (!owners.Contains(item.Value))
                {
                    owners.Add(item.Value);
                }
            }

            foreach (var item in owners)
            {
                System.Console.WriteLine(item);

            }
        }


    }
}