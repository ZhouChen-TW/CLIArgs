﻿namespace cliArgs
{
    public class ArgsParserBuilder
    {
        public ArgsParserBuilder AddFlagOption(string fullForm, char abbrForm, string description)
        {
            return this;
        }

        public ArgsParser Build()
        {
            return new ArgsParser();
        }
    }
}
