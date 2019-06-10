using AnagramCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramII
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Test_Empty_Return_Nothing()
        {
            AnagramC code = new AnagramC(new string[] { } );

            Assert.AreEqual(0, code.Solve().Count);
        }
        [Test]
        public void Test_One_Word_Return_Nothing()
        {
            AnagramC code = new AnagramC(new string[] {"hola" });

            Assert.AreEqual(0, code.Solve().Count);
        }
        [Test]
        public void Test_No_Anagram_Return_Nothing()
        {
            AnagramC code = new AnagramC(new string[] {"hola","lola"});

            Assert.AreEqual(0, code.Solve().Count);
        }
        [Test]
        public void One_Anagram_Return_Anagram()
        {
            AnagramC code = new AnagramC(new string[] {"hola","olah" });

            Assert.Contains("hola olah", code.Solve());
        }
        [Test]
        public void Some_Anagram_Return_Anagram()
        {
            AnagramC code = new AnagramC(@"C:\Users\USER\Desktop\Tendencias\Kata\TendenciasKata\Kata 3\AnagramTests.txt");

            Assert.Contains("maria riama", code.Solve());
        }
    }
}
