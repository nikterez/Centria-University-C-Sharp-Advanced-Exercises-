using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_005_i_owe_you
{
    public class IOU
    {
        private Dictionary<string, int> iou;
        public IOU()
        {
            this.iou = new Dictionary<string, int>();
        }

        public void ChangeDebt(string toWhom, int amount)
        {   
            if(this.iou.ContainsKey(toWhom))
            {
                 this.iou[toWhom] += amount;
            }
            else
            {
            this.iou.Add(toWhom,amount);
            }

            if(this.iou[toWhom]<0)
            {
                this.iou[toWhom]=0;
            }
            
        }

        public int HowMuchDoIOweTo(string toWhom)
        {
            foreach (var item in iou)
            {
                if (item.Key == toWhom)
                {
                    return item.Value;
                }
            }
            return 0;
        }


    }
}