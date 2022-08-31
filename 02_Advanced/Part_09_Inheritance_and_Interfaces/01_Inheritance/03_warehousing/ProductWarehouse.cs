using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_warehousing
{
    public class ProductWarehouse:Warehouse
    {
        public string productName;

        public ProductWarehouse(string productName,int capacity):base(capacity)
        {
            this.productName=productName;
        }

        public override string ToString()
        {
            return this.productName+": "+base.ToString();
        }
    }
}