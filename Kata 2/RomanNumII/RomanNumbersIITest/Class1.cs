using NUnit.Framework;
using RomanNumII;

namespace RomanNumbersIITest
{   
    [TestFixture]
    public class Class1
    {   
        private int Output(string get)
        {
            Roman R = new Roman();
            return R.Convert(get);
        }

        [Test]
        public void TestI()
        {
            
            Assert.AreEqual(1, Output("I"));
        }
        [Test] 
        public void TestXII()
        {
            Assert.AreEqual(12, Output("XII"));
        }
        [Test]
        public void IX()
        {
            Assert.AreEqual(9, Output("IX"));
        }
        [Test]
        public void XXVI()
        {
            Assert.AreEqual(26, Output("XXVI"));
        }
        [Test]
        public void more3K()
        {
            Assert.AreEqual(-1, Output("MMMI"));
        }
        [Test]
        public void Empty()
        {
            Assert.AreEqual(0, Output(" "));
        }
    }
}
