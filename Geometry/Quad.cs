using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Quad
    {
        public int Side1 { get; set; } = 5;
        public int Side2 { get; set; } = 4;
        public int Side3 { get; set; } = 6;
        public int Side4 { get; set; } = 3;
        


        public int Perimeter()
        {  
            return Side1 + Side2 + Side3 + Side4;
        } 
    }
}
