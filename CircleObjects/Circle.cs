using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    public class Circle
    {
        
        private double radius;

        // Property to access private radius
        public double Radius
        { get { return radius; } set { radius = value; } }

        // Method to calculate the circumference of a circle
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
         
        }

        // Method to calculate the area of a circle
        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }
        // Constructor
        public Circle(double radius)
        {
            Radius = radius;
           
        }
    }

}
