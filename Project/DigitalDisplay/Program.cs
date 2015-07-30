using DigitalDisplay.DI;
using DigitalDisplay.IO;
using DigitalDisplay.IO.Abstractions;
using DigitalDisplay.Parsers;
using System;

namespace DigitalDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /// We first setup our dependecies...
                var serializer = new Serializer();
                var fsController = new FSController();
                var logOutput = new LogOutput();
                InstanceResolverFor<ISerializer>.InstanceBuilder = () => serializer;
                InstanceResolverFor<ILogOutput>.InstanceBuilder = () => logOutput;
                InstanceResolverFor<IFSController>.InstanceBuilder = () => fsController;

#if Debug
                //args = new string[] { @"t>C:\git\DigitalDisplay\Training sets\Digital3\Training.txt" };
                //args = new string[] { @"i>C:\git\Training sets\Digital3\data.txt" };
#endif

                if ((args == null) || (args.Length != 1))
                {
                    throw new InvalidOperationException("The program failed to execute.");
                }

                foreach (var result in DataParserResult.LoadUsing(CommandParser.Parse(args[0])).Result)
                {
                    Console.WriteLine(result);
                }

            }
            catch (Exception e) { Console.WriteLine(e); }

            Console.WriteLine();
            Console.WriteLine("The end!");
            Console.ReadLine();
        }
    }
}
