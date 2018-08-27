using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge01
{
    public class RightAngleTriangle : Triangle
    {
        public RightAngleTriangle(string colour, float side1, float side2) : base(colour, side1, side2, 0)
        {
            Colour = colour;
            Side3Length = GetSide3();
        }

        public float GetSide3()
        {
            float side3sq = (float)Math.Pow(Side1Length, 2) + (float)Math.Pow(Side2Length, 2);
            float side3 = (float)Math.Sqrt(side3sq);
            return side3;
        }

        public override float GetPerimeter()
        {
            float perimeter = Side1Length + Side2Length + Side3Length;
            return perimeter;
        }

        public float GetArea()
        {
            float area = (float)0.5 * Side1Length * Side2Length;
            return area;
        }

        public string GetInfo()
        {
            string Info = String.Format("Colour: {0}, Side 1 Length: {1}, Side 2 Length: {2}, Perimeter: {3}, Area: {4}"
                , Colour, Side1Length, Side2Length, GetPerimeter(), GetArea());
            return Info;
        }
    }
}
