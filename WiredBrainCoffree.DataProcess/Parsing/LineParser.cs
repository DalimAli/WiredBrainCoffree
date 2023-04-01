using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffree.DataProcess.Model;

namespace WiredBrainCoffree.DataProcess.Parsing
{
    public class LineParser
    {
        public static MachineDataItem[] Parse(string[] csvLines)
        {
            var machineDataItems = new List<MachineDataItem>();

            foreach (var line in csvLines)
            {
                var machineDataItem = Parse(line);
                machineDataItems.Add(machineDataItem);
            }

            return machineDataItems.ToArray();
        }

        private static MachineDataItem Parse(string line)
        {
            var lineItem = line.Split(";");
            return new MachineDataItem(lineItem[0], DateTime.Parse(lineItem[1]));
        }
    }
}
