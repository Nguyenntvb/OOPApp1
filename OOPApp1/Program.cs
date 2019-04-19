using OOPApp1.Entities;
using OOPApp1.Responsive;
using OOPApp1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(2, 2, 2);
            ITriangleResponsive triangleResponsive = new TriangleResponsive();
            ITriangleService triangleService = new TriangleService(triangleResponsive);
            Console.WriteLine(triangleService.CheckTriangleType(triangle));
            Console.ReadLine();
        }
    }
}
