using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPApp1.Entities
{
    public class Triangle : Polygon
    {
        public Triangle(int side1, int side2, int side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        private int _side1;
        private int _side2;
        private int _side3;

        public int Side1
        {
            get { return _side1; }
            set { _side1 = value; }
        }
        public int Side2
        {
            get { return _side2; }
            set { _side2 = value; }
        }
        public int Side3
        {
            get { return _side3; }
            set { _side3 = value; }
        }

        public void Perimeter()
        {
            int total = _side1 + _side2 + _side3;
            Console.WriteLine(string.Format("Total is:{0}", total));
        }
    }
}
