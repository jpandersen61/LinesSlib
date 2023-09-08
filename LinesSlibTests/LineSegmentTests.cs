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
        LineSegment reference = new LineSegment()
        {
            Start = 8,
            End = 33
        };

        [TestMethod()]
        public void ToStringTest()
        {
            string s = reference.ToString();
            Assert.AreEqual<string>("Start: 8, End: 33", s);
        }

        [TestMethod()]
        [DataRow(8)]
        [DataRow(9)]
        [DataRow(20)]
        [DataRow(32)]
        [DataRow(33)]
        public void ContainsTest(int punkt)
        {
            Assert.AreEqual<bool>(true, reference.Contains(punkt));
        }

        [TestMethod()]
        public void ContainsTest1()
        {
            Assert.Fail();
        }
    }
}