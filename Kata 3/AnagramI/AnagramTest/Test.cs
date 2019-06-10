using AnagramI;
using NUnit.Framework;

namespace AnagramTest
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestNoWords()
        {
            AnagramC code = new AnagramC(new string[] { " " });
            Assert.AreEqual(0, code.AnagramSolution().Count);
        }
        [Test]
        public void W_One_Word_Return_0() {
            AnagramC code = new AnagramC(new string[] { "hola" });
            Assert.AreEqual(0, code.AnagramSolution().Count);
        }
        [Test]
        public void W_No_Anagram_Return_0() {
            AnagramC code = new AnagramC(new string[] { "hola", "pepe" });
            Assert.AreEqual(0, code.AnagramSolution().Count);
        }
        [Test]
        public void W_One_Anagram_Return_Anagram()
        {
            AnagramC code = new AnagramC(new string[] { "hola", "olah" });
            Assert.Contains("hola olah", code.AnagramSolution());
        }
        [Test]
        public void W_Some_Anagram_Return_Anagram()
        {
            AnagramC code = new AnagramC(@"C:\Users\USER\Desktop\Tendencias\Kata\TendenciasKata\Kata 3\AnagramTests.txt");
            Assert.AreEqual(4, code.AnagramSolution().Count);
        }
        [Test]
        public void Several_Anagram_Return_Anagrams()
        {
            AnagramC code = new AnagramC(@"C:\Users\USER\Desktop\Tendencias\Kata\TendenciasKata\Kata 3\INPUT.txt");
            Assert.AreEqual(30404, code.AnagramSolution().Count);
        }

        [Test]
        public void LongestAnagram()
        {
            AnagramC code = new AnagramC(@"C:\Users\USER\Desktop\Tendencias\Kata\TendenciasKata\Kata 3\INPUT.txt");
            Assert.AreEqual("Slater alerts alters artels estral laster rastle ratels salter slater staler stelar talers tarsel", code.LongestAnagramSet());
        }
    }
}
