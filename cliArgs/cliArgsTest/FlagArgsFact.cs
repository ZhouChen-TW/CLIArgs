using cliArgs;
using Xunit;

namespace cliArgsTest
{
    public class FlagArgsFact
    {
        [Fact]
        public void should()
        {
            ArgsParser parser = new ArgsParserBuilder()
                .AddFlagOption("flag", 'f', "This is a description")
                .Build();

            ArgsParsingResult result = parser.Parse(new [] { "--flag" });
            Assert.True(result.GetFlagValue("-f"));
        }
    }
}
