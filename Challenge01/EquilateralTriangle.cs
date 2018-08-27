using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge01
{
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(string colour, float side1) : base(colour, side1, side1, side1)
        {
            Colour = colour;
            Side1Length = side1;
        }

        public override float GetPerimeter()
        {
            float perimeter = Side1Length + Side2Length + Side3Length;
            return perimeter;
        }

        public float GetArea()
        {
            float area = (float)Math.Sqrt(3) / 4 * (float)Math.Pow(Side1Length, 2);
            return area;
            // sqaure root of 3 / 4 * Side1Length
        }

        public string GetInfo()
        {
            string Info = String.Format("Colour: {0}, Side Length: {1}, Perimeter: {2}, Area: {3}", Colour, Side1Length, GetPerimeter(), GetArea());
            return Info;
        }
    }
}
