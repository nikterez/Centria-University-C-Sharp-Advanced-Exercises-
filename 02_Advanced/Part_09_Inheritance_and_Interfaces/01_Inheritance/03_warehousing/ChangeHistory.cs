using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_warehousing
{
    public class ChangeHistory
    {
        private List<int> history;

        public ChangeHistory()
        {
            this.history = new List<int>();
        }

        public void Add(int status)
        {
            this.history.Add(status);
        }

        public void Clear()
        {
            this.history.Clear();
        }

        public int MaxValue()
        {
            if (this.history.Count == 0)
            {
                return 0;
            }
            return this.history.Max();
        }

        public int MinValue()
        {
            if (this.history.Count == 0)
            {
                return 0;
            }
            return this.history.Min();
        }

        public override string ToString()
        {
            return "Current: " + this.history[^1] + " Min: " + this.MinValue() + " Max: " + this.MaxValue();
        }
    }
}