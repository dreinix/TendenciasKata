using NUnit.Framework;
using RomanNumI;

namespace RomanNumITDD
{   
    [TestFixture]
    public class Test
    {   
        int output(string input)
        {
            Roman R = new Roman();
            return R.Convert(input);
        }
        [Test]
        public void TestOneInRoman()
        {
            
            string Input = "I";            
            Assert.AreEqual(1, output(Input));
        }
        [Test]
        public void TestV()
        {
            string Input = "V";
            Assert.AreEqual(5, output(Input));
        }

        [Test]
        public void TestVIII()
        {
            string Input = "VIII";
            Assert.AreEqual(8, output(Input));
        }
    }
}
