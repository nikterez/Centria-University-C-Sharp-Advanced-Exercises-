using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_009_storage_facility
{
    public class StorageFacility
    {
        private Dictionary<string, List<string>> storage;

        public StorageFacility()
        {
            this.storage = new Dictionary<string, List<string>>();
        }

        public void Add(string unit, string item)
        {
            if (!this.storage.ContainsKey(unit.ToLower()))
            {
                this.storage.Add(unit, new List<string>());
            }
            this.storage[unit.ToLower()].Add(item);

        }

        public List<string> Contents(string storageUnit)
        {
            if (this.storage.ContainsKey(storageUnit) && this.storage[storageUnit] != null)
            {
                return this.storage[storageUnit];
            }
            return new List<string>();
        }

        public void Remove(string storageUnit, string item)
        {
            if (this.storage.ContainsKey(storageUnit) && this.storage[storageUnit].Contains(item))
            {
                this.storage[storageUnit].Remove(item);
            }
            if (this.storage[storageUnit].Count == 0)
            {
                this.storage.Remove(storageUnit);
            }

        }

        public List<string> StorageUnits()
        {
            List<string> units = new List<string>();
            foreach (var i in this.storage.Keys)
            {
                units.Add(i);
            }
            return units;
        }


    }
}