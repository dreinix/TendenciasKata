using NUnit.Framework;
using SCI;

namespace SCItest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestEmpty()
        {
            SC calc = new SC("");
            Assert.AreEqual("0",calc.add());
        }
        [Test]
        public void TestOneoNum()
        {
            SC calc = new SC("1");
            Assert.AreEqual("1", calc.add());
        }
        [Test]
        public void TestTwoNum()
        {
            SC calc = new SC("1,2");
            Assert.AreEqual("3", calc.add());
        }
        [Test]
        public void TestSomeNum()
        {
            SC calc = new SC("1,2,3,4,5");
            Assert.AreEqual("15", calc.add());
        }
        [Test]
        public void TestNegativeNum()
        {
            SC calc = new SC("1,2,3,4,-5");
            Assert.AreEqual("Negative not allowed:-5 ,", calc.add());
        }
        [Test]
        public void TestDelimitersParameter()
        {
            SC calc = new SC("1,2,3,4\n5", new char[] { '\n', ',', ';' });
            Assert.AreEqual("15", calc.add());
        }
        [Test]
        public void TestNewDelimiterNum()
        {
            SC calc = new SC("1,2,3,4\n5");
            Assert.AreEqual("15", calc.add());
        }
        [Test]
        public void TestDelimiterErrorNum()
        {
            SC calc = new SC("1,2,3,4,\n-5");
            Assert.AreEqual("Delimiter error:\n ,Negative not allowed:-5 ,", calc.add());
        }

        
    }
}
