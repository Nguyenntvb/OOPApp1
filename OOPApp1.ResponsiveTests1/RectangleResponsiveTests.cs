using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPApp1.Entities;
using OOPApp1.Responsive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPApp1.Responsive.Tests
{
    [TestClass()]
    public class RectangleResponsiveTests
    {
        [TestMethod()]
        public void CheckTriangleTypeScaleneTest()
        {
            Triangle triangle = new Triangle(1, 2, 3);
            ITriangleResponsive triangleResponsive = new TriangleResponsive();
            TriangleType triangleType = triangleResponsive.CheckTriangleType(triangle);
            Assert.AreEqual(TriangleType.Scalene,triangleType);
        }

        [TestMethod()]
        public void CheckTriangleTypeIsoscelesTest()
        {
            Triangle triangle = new Triangle(2, 2, 3);
            ITriangleResponsive triangleResponsive = new TriangleResponsive();
            TriangleType triangleType = triangleResponsive.CheckTriangleType(triangle);
            Assert.AreEqual(TriangleType.Isosceles,triangleType);
        }

        [TestMethod()]
        public void CheckTriangleTypeIsosceles2Test()
        {
            Triangle triangle = new Triangle(1, 2, 2);
            ITriangleResponsive triangleResponsive = new TriangleResponsive();
            TriangleType triangleType = triangleResponsive.CheckTriangleType(triangle);
            Assert.AreEqual(TriangleType.Isosceles,triangleType);
        }

        [TestMethod()]
        public void CheckTriangleTypeEquilateralTest()
        {
            Triangle triangle = new Triangle(2, 2, 2);
            ITriangleResponsive triangleResponsive = new TriangleResponsive();
            TriangleType triangleType = triangleResponsive.CheckTriangleType(triangle);
            Assert.AreEqual(TriangleType.Equilateral,triangleType);
        }
    }
}