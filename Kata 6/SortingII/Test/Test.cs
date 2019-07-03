using NUnit.Framework;
using SortingII;

namespace Test
{   
    [TestFixture]
    public class Test
    {
        [Test]
        public void NoString()
        {
            Sorting S = new Sorting("");
            Assert.AreEqual(null, S.Sort());
        }
        [Test]
        public void SortedString()
        {
            Sorting S = new Sorting("aab");
            Assert.AreEqual("aab", S.Sort());
        }
        [Test]
        public void NotSortedString()
        {
            Sorting S = new Sorting("aba");
            Assert.AreEqual("aab", S.Sort());
        }
        [Test]
        public void NotSortedStringLong()
        {
            Sorting S = new Sorting("abdcfg lapl");
            Assert.AreEqual("aabcdfgllp", S.Sort());
        }
        [Test]
        public void NotSortedStringLongWithCharacter()
        {
            Sorting S = new Sorting("abdcfg %%^&*()_+=@#$*/-.,/ lapl");
            Assert.AreEqual("aabcdfgllp", S.Sort());
        }
        [Test]
        public void OnlyCharacter()
        {
            Sorting S = new Sorting(" %%^&*()_+=@#$*/-.,/");
            Assert.AreEqual(null, S.Sort());
        }
    }
}
