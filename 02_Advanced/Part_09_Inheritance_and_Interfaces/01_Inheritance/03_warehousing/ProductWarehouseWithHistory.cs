using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_warehousing
{
    public class ProductWarehouseWithHistory:ProductWarehouse
    {
        private ChangeHistory history;

        public ProductWarehouseWithHistory(string productName, int capacity, int initialBalance):base(productName,capacity)
        {
            base.balance=initialBalance;
            this.capacity-=initialBalance;
            this.history=new ChangeHistory();
            this.history.Add(initialBalance);
        }

        public string History()
        {
            return this.history.ToString();
        }

        new public void AddToWarehouse(int amount)
        {
            base.AddToWarehouse(amount);
            history.Add(this.balance);
        }
        new public int TakeFromWarehouse(int amount)
        {
            base.TakeFromWarehouse(amount);
            history.Add(this.balance);
            return amount;
        }
    }
}