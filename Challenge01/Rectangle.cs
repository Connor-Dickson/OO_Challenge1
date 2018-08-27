using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge01
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string colour, int side1length, int side2length) : base(colour, side1length, side2length, side1length, side2length)
        {
            Colour = colour;
            Side1Length = side1length;
            Side2Length = side2length;
        }

        public int GetArea()
        {
            int area = Side1Length * Side2Length;
            return area;
        }

        public override int GetPerimeter()
        {
            int perimeter = Side1Length + Side2Length + Side1Length + Side2Length;
            return perimeter;
        }

        public string GetInfo()
        {
            string Info = String.Format("Colour: {0}, Side 1 Length: {1}, Side 2 Length: {2}, Perimeter: {3}, Area: {4}"
                , Colour, Side1Length, Side2Length, GetPerimeter(), GetArea());
            return Info;
        }
    }
}
