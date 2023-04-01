using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCoffree.DataProcess.Model
{
    public class MachineDataItem
    {
        public MachineDataItem(string coffeeType, DateTime createdAt)
        {
            this.CoffeeType = coffeeType;
            this.CreatedAt = createdAt;
        }

        public string CoffeeType { get; }
        public DateTime CreatedAt { get; }
    }
}
