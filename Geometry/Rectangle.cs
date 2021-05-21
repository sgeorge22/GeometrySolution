using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Rectangle
    {
        public int SideR1 { get; set; } = 6;
        public int SideR2 { get; set; } = 9;

        public int perimeter()
        {
            return SideR1 * 2 + SideR2 * 2;
        }
        public int area()
        {
            return SideR1 * SideR2;
        }
    }
}
