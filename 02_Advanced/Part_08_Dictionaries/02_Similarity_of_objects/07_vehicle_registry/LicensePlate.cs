using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_007_vehicle_registry
{
    public class LicensePlate
    {
        private string liNumber;
        private string country;

        public LicensePlate(string country, string liNumber)
        {
            this.liNumber = liNumber;
            this.country = country;
        }


        public override string ToString()
        {
            return country + " " + liNumber;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            LicensePlate compared = (LicensePlate)obj;

            return this.liNumber == compared.liNumber && this.country == compared.country;
        }

        public override int GetHashCode()
        {
            return this.liNumber.GetHashCode() + this.country.GetHashCode();
        }
    }
}