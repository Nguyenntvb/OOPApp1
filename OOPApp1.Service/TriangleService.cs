using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOPApp1.Entities;
using OOPApp1.Responsive;

namespace OOPApp1.Service
{
    public class TriangleService : ITriangleService
    {
        ITriangleResponsive _rectangleResponsive { get; set; }

        public TriangleService(ITriangleResponsive rectangleResponsive)
        {
            _rectangleResponsive = rectangleResponsive;
        }

        public string CheckTriangleType(Triangle triangle)
        {
            TriangleType triangleType = _rectangleResponsive.CheckTriangleType(triangle);
            switch (triangleType)
            {
                case TriangleType.Scalene:
                    return "This is Scalene";
                case TriangleType.Isosceles:
                    return "This is Isosceles";
                case TriangleType.Equilateral:
                    return "This is Equilateral";
                case TriangleType.Error:
                default:
                    return "Error";
            }
        }
    }
}
