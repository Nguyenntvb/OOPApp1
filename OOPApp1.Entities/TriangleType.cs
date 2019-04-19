using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPApp1.Entities
{
    public enum TriangleType
    {
        Scalene = 1, // no two sides are the same length
        Isosceles = 2, // two sides are the same length and one differs
        Equilateral = 3, // all sides are the same length
        Error = 4 // inputs can't produce a triangle
    }
}
