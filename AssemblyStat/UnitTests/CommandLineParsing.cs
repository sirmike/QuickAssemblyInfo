using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using AssemblyStat.BO;
using AssemblyStat.Exceptions;
using System.Collections.Specialized;

namespace AssemblyStat.UnitTests
{
    [TestFixture]
    public class CommandLineParsing
    {
        [Test]
        public void ParseParameter_Normal()
        {
            CommandLineParser parser = new CommandLineParser();
            KeyValuePair<string, string> result = parser.ParseParam("--assembly=param");
            Assert.AreEqual(Consts.AllowedParameters.Assembly, result.Key);
            Assert.AreEqual("param", result.Value);
        }

        [Test]
        [ExpectedException(typeof(FormatException))]
        public void ParseParameter_BeginSpaceInName()
        {
            CommandLineParser parser = new CommandLineParser();
            KeyValuePair<string, string> result = parser.ParseParam(" --assembly=param");
        }

        [Test]
        public void ParseParameter_SpaceInValue()
        {
            CommandLineParser parser = new CommandLineParser();
            KeyValuePair<string, string> result = parser.ParseParam("--assembly=param eter");
            Assert.AreEqual(Consts.AllowedParameters.Assembly, result.Key);
            Assert.AreEqual("param eter", result.Value);
        }

        [Test]
        [ExpectedException(typeof(UnknownParamNameException))]
        public void ParseParameter_SeparatorSpace()
        {
            CommandLineParser parser = new CommandLineParser();
            KeyValuePair<string, string> result = parser.ParseParam("--assembly = param");
        }

        [Test]
        [ExpectedException(typeof(UnknownParamNameException))]
        public void ParseParameter_UnallowedParameterName()
        {
            CommandLineParser parser = new CommandLineParser();
            KeyValuePair<string, string> result = parser.ParseParam(@"--dupa=abds");
        }

        [Test]
        [ExpectedException(typeof(UnknownParamNameException))]
        public void ParseParameter_UnknownParameterName()
        {
            CommandLineParser parser = new CommandLineParser();
            KeyValuePair<string, string> result = parser.ParseParam(@"abcdef");
        }

        [Test]
        public void ParseParameter_FullPathValue()
        {
            CommandLineParser parser = new CommandLineParser();
            KeyValuePair<string, string> result = parser.ParseParam(@"--assembly=c:\abcd\def\giabcdef.dll");
            Assert.AreEqual(Consts.AllowedParameters.Assembly, result.Key);
            Assert.AreEqual(@"c:\abcd\def\giabcdef.dll", result.Value);
        }

        [Test]
        public void ParseAll()
        {
            CommandLineParser parser = new CommandLineParser();
            StringDictionary result = parser.ParseParams(@"--assembly=abds  --directory=abcd\");
            Assert.That(result.ContainsKey(Consts.AllowedParameters.Assembly));
            Assert.That(result.ContainsKey(Consts.AllowedParameters.Directory));

            Assert.AreEqual("abds", result[Consts.AllowedParameters.Assembly]);
            Assert.AreEqual(@"abcd\", result[Consts.AllowedParameters.Directory]);
        }

        [Test]
        public void ParseAll_ManySpacesBetween()
        {
            CommandLineParser parser = new CommandLineParser();
            StringDictionary result = parser.ParseParams(@"     --assembly=abds  --directory=abcd\");
            Assert.That(result.Count == 2);

            Assert.That(result.ContainsKey(Consts.AllowedParameters.Assembly));
            Assert.That(result.ContainsKey(Consts.AllowedParameters.Directory));

            Assert.AreEqual("abds", result[Consts.AllowedParameters.Assembly]);
            Assert.AreEqual(@"abcd\", result[Consts.AllowedParameters.Directory]);
            
        }
    }
}
