using WiredBrainCoffree.DataProcess.Model;
using WiredBrainCoffree.DataProcess.Parsing;
using WiredBrainCoffree.DataProcess.Processing;

namespace WiredBrainCoffree.DataProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("------------------Wired Brain Coffee - Data Process----------------");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();

            const string fileName = "WiredBrainCoffee1.csv";

            string[] csvLines = File.ReadAllLines(fileName);
            MachineDataItem[] machineDataItems = LineParser.Parse(csvLines);

            var machineDataProcessor = new MachineDataProcessor();
            machineDataProcessor.ProcessItems(machineDataItems);


            Console.WriteLine();
            Console.WriteLine($"-----------File {fileName} was Processed successfully------------");

            Console.ReadLine();
        }
    }
}