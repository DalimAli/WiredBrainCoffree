using WiredBrainCoffree.DataProcess.Parsing;

namespace WiredBrainCoffree.DataProcessorXUnitTest.Parser
{
    public class LineParserTest
    {
        [Fact]
        public void ShouldParseValidLine()
        {
            string[] lines = new[] { "Express;10/2/2022 8:22:16 AM" };
           var machineDataItems = LineParser.Parse(lines);

            Assert.NotNull(machineDataItems);
            Assert.Single(machineDataItems);
            Assert.Equal("Express", machineDataItems[0].CoffeeType);
            Assert.Equal(new DateTime(2022,10, 2, 8, 22, 16), machineDataItems[0].CreatedAt);


        }
    }
}
