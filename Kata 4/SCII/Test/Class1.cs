using NUnit.Framework;
using SCII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{   
    [TestFixture]
    public class Class1
    {
        [Test]
        public void NoNumbers()
        {
            SC convert = new SC("");

            Assert.AreEqual("0", convert.calc());
        }
        [Test]
        public void OneNumber()
        {
            SC convert = new SC("5");

            Assert.AreEqual("5", convert.calc());
        }
        [Test]
        public void TwoNumbers()
        {
            SC convert = new SC("5,6");

            Assert.AreEqual("11", convert.calc());
        }
        [Test]
        public void SomeNumbers()
        {
            SC convert = new SC("5,6,10,9");

            Assert.AreEqual("30", convert.calc());
        }
        [Test]
        public void SomeNumbersTwoSeparator()
        {
            SC convert = new SC("5\n6,10\n9");

            Assert.AreEqual("30", convert.calc());
        }
        [Test]
        public void NegativeNumber()
        {
            SC convert = new SC("-5\n6,10\n9");

            Assert.AreEqual("Negative not allow,", convert.calc());
        }

        [Test]
        public void ParseError()
        {
            SC convert = new SC("5\n,6,10\n9");

            Assert.AreEqual("Parse error,", convert.calc());
        }
        [Test]
        public void SomeError()
        {
            SC convert = new SC("-5\n,6,10\n9");

            Assert.AreEqual("Negative not allow,Parse error,", convert.calc());
        }
        [Test]
        public void NewParse()
        {
            SC convert = new SC("5\n6,10;9", new Char[] {'\n',',',';'});

            Assert.AreEqual("30", convert.calc());
        }
        [Test]
        public void NewParseError()
        {
            SC convert = new SC(",5\n;6,10;9", new Char[] { '\n', ',', ';' });

            Assert.AreEqual("Parse error,", convert.calc());
        }
    }
}
