using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            var quad = new Quad();
            //quad.Side1 = 20; you can add in the quad side lenghts this way
           
            var perimeter = quad.Perimeter();
            Console.WriteLine($"The perimeter of the quad is {perimeter}.");

            
            
            var sqr = new Square();

            var perimeterSqr = sqr.perimeter();
            var area = sqr.area();
            Console.WriteLine($"The perimeter of the square is {perimeterSqr}. The area of the square is {area}.");

            
            
            var rec = new Rectangle();
            var perimeterRec = rec.perimeter();
            var areaRec = rec.area();
            rec.SideR1 = 6;
            rec.SideR2 = 9;
            Console.WriteLine($"The perimeter of the rectangle is {perimeterRec}. The area of the rectangle is {areaRec}.");



        }
    }
}
