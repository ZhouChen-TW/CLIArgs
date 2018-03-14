using cliArgs;
using Xunit;

namespace cliArgsTest
{
    public class FlagArgsFact
    {
        [Fact]
        public void should_be_false_when_input_empty_string()
        {
            ArgsParser parser = new ArgsParserBuilder()
                .AddFlagOption("flag", 'f', "This is a description")
                .Build();

            ArgsParsingResult result = parser.Parse(new [] { "" });
            Assert.False(result.GetFlagValue("-f"));
        }
    }
}
