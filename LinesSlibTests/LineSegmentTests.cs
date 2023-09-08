using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinesSlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesSlib.Tests
{
    [TestClass()]
    public class LineSegmentTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            LineSegment ls = new LineSegment();
            string s = ls.ToString();
        }

        [TestMethod()]
        public void ContainsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ContainsTest1()
        {
            Assert.Fail();
        }
    }
}