using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge01
{
    public class Triangle : Shape
    {
        public float Side1Length { get; set; }
        public float Side2Length { get; set; }
        public float Side3Length { get; set; }

        public Triangle(string colour, float side1, float side2, float side3) : base(colour)
        {
            Colour = colour;
            Side1Length = side1;
            Side2Length = side2;
            Side3Length = side3;
        }

        public virtual float GetPerimeter()
        {
            float perimeter = Side1Length + Side2Length + Side3Length;
            return perimeter;
        }
    }
}
