using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesSlib
{
    /// <summary>
    /// Line segment class 
    /// </summary>
    public class LineSegment
    {
        /// <summary>
        /// 
        /// </summary>
        public int Start { get; set; }
        public int End { get; set; }

        public override string ToString()
        {
            //throw new NotImplementedException();
            return $"Start: {Start}, End: {End}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="punkt">Punkt der skal checked for..</param>
        /// <returns></returns>
        public bool Contains(int punkt)
        {
            
            return (Start <= punkt) && (End >= punkt);
        }

        public bool Contains(LineSegment lineSegment)
        {           
            return (Start <= lineSegment.Start) && (End >= lineSegment.End);
        }

        public bool Intersection(LineSegment anotherSegment)
        {
            return    (Start >= anotherSegment.Start) && (End >= anotherSegment.End)
                   || (Start <= anotherSegment.Start) && (End <= anotherSegment.End);
        }
    }
}
