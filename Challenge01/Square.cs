using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge01
{
    public class Square : Quadrilateral
    {
        public Square(string colour, int side1length) : base(colour, side1length, side1length, side1length, side1length)
        {
            Colour = colour;
            Side1Length = side1length;
        }

        public int GetArea()
        {
            int area = Side1Length * Side1Length;
            return area;
        }

        public override int GetPerimeter()
        {
            int perimeter = Side1Length + Side1Length + Side1Length + Side1Length;
            return perimeter;
        }

        public string GetInfo()
        {
            string Info = String.Format("Colour: {0}, Side Length: {1}, Perimeter: {2}, Area: {3}", Colour, Side1Length, GetPerimeter(), GetArea());
            return Info;
        }
    }
}
