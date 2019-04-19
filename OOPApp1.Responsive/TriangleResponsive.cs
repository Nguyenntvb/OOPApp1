using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOPApp1.Entities;

namespace OOPApp1.Responsive
{
    public class TriangleResponsive : ITriangleResponsive
    {
        public TriangleType CheckTriangleType(Triangle triangle)
        {
            if (triangle.Side1 <=0 || triangle.Side2 <= 0 || triangle.Side3 <= 0)
            {
                return TriangleType.Error;
            }

            if (triangle.Side1 == triangle.Side2 && triangle.Side2 == triangle.Side3)
            {
                return TriangleType.Equilateral;
            }
            else if (triangle.Side1 == triangle.Side2 || triangle.Side1 == triangle.Side3 || triangle.Side2 == triangle.Side3)
            {
                return TriangleType.Isosceles;
            }
            else
            {
                return TriangleType.Scalene;
            }
            
        }
    }
}
