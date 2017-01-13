using Microsoft.Extensions.CommandLineUtils;
using System;

namespace dotnetcoretool
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new CommandLineApplication()
            {
                Name = "dotnetcoretool",
                Description = "dotnetcoretool"
            };

            app.HelpOption("-h|--help");

            app.OnExecute(() =>
            {
                app.ShowHelp();
                return 1;
            });

            app.Execute(args);
        }
    }
}