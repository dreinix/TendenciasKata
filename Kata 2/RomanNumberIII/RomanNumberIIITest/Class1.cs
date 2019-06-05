using NUnit.Framework;
using RomanNumberIII;

namespace RomanNumberIIITest
{
    [TestFixture]
    public class Class1
    {
        private int Output(string val)
        {
            Roman R = new Roman();

            return R.Convert(val.ToUpper());
        }

        [Test]
        public void Testxxi()
        {
            Assert.AreEqual(21, Output("xxi"));
        }
        [Test]
        public void TestXXI()
        {
            Assert.AreEqual(21, Output("XXI"));
        }
        [Test]
        public void Testix()
        {
            Assert.AreEqual(9, Output("ix"));
        }
        [Test]
        public void Testiv()
        {
            Assert.AreEqual(4, Output("iv"));
        }
        [Test]
        public void LMC()
        {
            Assert.AreEqual(-1, Output("LMC"));
        }
    }
}
