using NUnit.Framework;
using SortingI;

namespace Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void emptyString()
        {
            Sorting S = new Sorting("");

            Assert.Throws<NoStringExcepction>(()=>S.Sort());
        }

        [Test]
        public void AlreadySortedString()
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
            Sorting S = new Sorting("adcbop acbd");
            Assert.AreEqual("aabbccddop", S.Sort());
        }
        [Test]
        public void NotSortedStringLongWithCharacters()
        {
            Sorting S = new Sorting("adcbop . / * - ) 0 ( + ==-_%$#@ acbd");
            Assert.AreEqual("aabbccddop", S.Sort());
        }
    }
}
