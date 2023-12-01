using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis3
{
    public class WaterIntake
    {
        public int Amount { get; set; }

        public void AddWater(int amount)
        {
            Amount += amount;
        }
    }
}
