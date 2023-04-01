using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffree.DataProcess.Model;

namespace WiredBrainCoffree.DataProcess.Processing
{
    public class MachineDataProcessor
    {
        private readonly Dictionary<string, int> _countPerCoffeeType = new();

        public void ProcessItems(MachineDataItem[] machineDataItems)
        {
            _countPerCoffeeType.Clear();
            foreach (var item in machineDataItems)
            {
                ProcessItem(item);
            }
            SaveCountPerCoffeeType();
        }

        private void ProcessItem(MachineDataItem item)
        {
            if (!_countPerCoffeeType.ContainsKey(item.CoffeeType))
            {
                _countPerCoffeeType.Add(item.CoffeeType, 1);
            }
            else
            {
                _countPerCoffeeType[item.CoffeeType]++;
            }
        }

        private void SaveCountPerCoffeeType()
        {
            foreach(var entity in _countPerCoffeeType)
            {
                var line = $"{entity.Key} : {entity.Value}";
                Console.WriteLine(line);
            }
        }
    }
}
