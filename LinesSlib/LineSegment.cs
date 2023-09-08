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
            return $"Start: {Start}, End: {End}";
        }

        public bool Contains(int punkt)
        {
            return (Start <= punkt) && (End >= punkt);
        }

        public bool Contains(LineSegment lineSegment)
        {
            throw new NotImplementedException();
        }
    }
}
