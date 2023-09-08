using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesSlib
{
    public class LineSegment
    {
        public int Start { get; set; }
        public int End { get; set; }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int punkt)
        {
            throw new NotImplementedException();
        }

        public bool Contains(LineSegment lineSegment)
        {
            throw new NotImplementedException();
        }
    }
}
