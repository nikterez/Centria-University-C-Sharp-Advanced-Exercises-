using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_warehousing
{
    public class Warehouse
    {
        public int balance;

        public int capacity;

        public Warehouse(int capacity)
        {
            this.capacity = capacity;
        }

        public int HowMuchSpaceLeft()
        {
            return this.capacity - this.balance;
        }

        public void AddToWarehouse(int amount)
        {
            if(amount<=0)
            {
                return;
            }
            
            int newBalance = this.balance + amount;
            int newCapacity = this.capacity - amount;

            if (amount > 0 && newBalance <= this.capacity)
            {
                this.balance = newBalance;
                this.capacity = newCapacity;
            }
            
            else if (amount > 0 && newBalance > this.capacity)
            {      
                this.balance+=this.capacity;
                this.capacity=0;
            }   

        }

        public int TakeFromWarehouse(int amount)
        {
            if(amount<=0)
            {
                return 0;
            }
            
            int newBalance = this.balance - amount;
            int newCapacity = this.capacity + amount;

            if (amount > 0 && newBalance>=0)
            {
                this.balance = newBalance;
                this.capacity = newCapacity;
            }
            else if (amount > 0 && newBalance<0)
            {
                this.capacity+=this.balance;
                this.balance=0;
            }

            return amount;
        }

        public override string ToString()
        {
            return "balance: " + this.balance + ", space left: " + this.capacity;
        }
    }
}