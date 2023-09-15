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
        const int refStart = 8;
        const int refEnd = 33;
        LineSegment reference = new LineSegment()
        {
            Start = refStart,
            End = refEnd
        };

        [TestMethod()]
        public void ToStringTest()
        {
            string s = reference.ToString();
            Assert.AreEqual<string>("Start: 8, End: 33", s);
        }

        [TestMethod()]
        [DataRow(refStart,refEnd)]
        [DataRow(refStart+1, refEnd-1)]
        public void ContainsTestPositive(int start, int end)
        {
            LineSegment ls = new LineSegment()
            {
                Start = start,
                End = end
            };
            Assert.AreEqual<bool>(true, reference.Contains(ls));
        }

        [TestMethod()]
        [DataRow(8)]
        [DataRow(9)]
        [DataRow(20)]
        [DataRow(32)]
        [DataRow(33)]
        public void ContainsTestPositive(int point)
        {
            Assert.AreEqual<bool>(true, reference.Contains(point));
        }

        [TestMethod()]
        [DataRow(refStart-1, refEnd-1)]
        [DataRow(refStart + 1, refEnd + 1)]
        public void IntersectionTestPositive(int start, int end)
        {
            LineSegment ls = new LineSegment()
            {
                Start = start,
                End = end
            };
            Assert.AreEqual<bool>(true, reference.Intersection(ls));
        }
    }
}