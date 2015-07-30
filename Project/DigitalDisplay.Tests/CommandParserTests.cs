using DigitalDisplay.DI;
using DigitalDisplay.IO.Abstractions;
using DigitalDisplay.Parsers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DigitalDisplay.Tests.Fakes;

namespace DigitalDisplay.Tests
{
    [TestClass]
    public class CommandParserTests
    {
        [TestMethod]
        public void Validate_Input_Parameters()
        {
            /// WE first setup the fake for IO bound operation
            InstanceResolverFor<IFSController>.InstanceBuilder = () => new FakeFSController { FakeExists = _ => !string.IsNullOrEmpty(_) };
            InstanceResolverFor<ILogOutput>.InstanceBuilder = () => new FakeLogOutput();

            /// Now based on the following scenarios [key=parameter, value=is it expected to be valid]
            var parameterDictionary = new Dictionary<string, bool> 
            {
                {"i>C:\\MyFile.txt", true},
                {"t>C:\\MyFile.txt", true},
                {"C:\\MyFile.txt", false},
                {"t", false},
                {"i>", false},
                {">C:\\MyFile.txt", false},
                {">>C:\\MyFile.txt", false}
            };

            /// We check the odds
            foreach (var parameter in parameterDictionary)
            {
                var result = CommandParser.Parse(parameter.Key);
                Assert.AreEqual(result.IsValid, parameter.Value);
            }
        }
    }
}
