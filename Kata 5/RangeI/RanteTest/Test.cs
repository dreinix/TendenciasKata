using NUnit.Framework;
using Range;

namespace RanteTest
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Empty()
        {
            Assert.Throws<InvalidRangeException>(()=> new Ranges(""));
        }
        [Test]
        public void CaracterMissing()
        {
            Assert.Throws<InvalidRangeException>(() => new Ranges("(5,6"));
        }
        [Test]
        public void InvalidRange()
        {
            Assert.Throws<InvalidRangeException>(() => new Ranges("(6,5)"));
        }
        [Test]
        public void ContainRange()
        {
            Ranges rang = new Ranges("(6,9)");

            Assert.AreEqual(true, rang.cont("(7,8)"));
        }
        [Test]
        public void NotContainRange()
        {
            Ranges rang = new Ranges("(6,9)");

            Assert.AreEqual(false, rang.cont("(4,8)"));
        }
    }
}
