using System;
using System.Collections.Generic;
using System.Text;
using Ookii.CommandLine;

namespace ProtocolHandler
{
    class Options
    {
        [CommandLineArgument, Alias("H"), Alias("?")]
        public bool Help { get; set; }

        [CommandLineArgument(Position = 0)]
        public string URI { get; set; }
    }
}
