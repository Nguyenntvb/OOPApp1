using OOPApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPApp1.Responsive
{
    public interface ITriangleResponsive
    {
        TriangleType CheckTriangleType(Triangle triangle);
    }
}
