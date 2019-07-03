using NUnit.Framework;
using RangeII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RangeII.Range;

namespace RangeTest
{   
    [TestFixture]
    public class Test
    {
        [Test]
        public void TesEmpty()
        {
            Assert.Throws<InvalidRangeException>(() => new Range(""));
        }
        [Test]
        public void InvalidRange()
        {
            Assert.Throws<InvalidRangeException>(() => new Range("(4,5"));
        }
        [Test]
        public void InvalidRangeII()
        {
            Assert.Throws<InvalidRangeException>(() => new Range("(5,4"));
        }
        [Test]
        public void ContainsI()
        {
            Range rang = new Range("(4,8)");
            Assert.AreEqual(true, rang.Contain("(5,6)"));
        }
        [Test]
        public void SameAs()
        {
            Range rang = new Range("(4,8)");
            Assert.AreEqual(true, rang.SameAs("[5,9]"));
        }

    }
}
