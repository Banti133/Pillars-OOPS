using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars_OOPS
{
    internal class Rectangle 
    {
        private double Length;
        private double Breadth;
       
        public Rectangle(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        public double Len
        {
            get { return Length; }
            set { Length = value; }
        }
        public double Brd
        {
            get { return Breadth; }
            set { Breadth = value; }
        }
        // Method to calculate area of rectangle
        public double Area()
        {
            return Len*Brd ;
        }
        public override string ToString()
        {
            return $"Rectangle: Length = {Len}, Breadth = {Brd}, Area = {Area()}";
        }
    }
}
