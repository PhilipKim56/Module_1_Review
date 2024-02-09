using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Review
{
    public class ShapeCalculator
    {

        public static double CalculateCircleArea(double radius)
        {

            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }


        public static void CirTest(string[] args)
        {
            double radius = 5.0;
            double area = CalculateCircleArea(radius);
            Console.WriteLine($"Area of the circle with radius {radius} is: {area}");
        }




        public static double CalculateTriangleArea(double baseLength, double height)
        {

            double area = 0.5 * baseLength * height;
            return area;
        }


        public static void TriTest(string[] args)
        {
            double baseLength = 5.0;
            double height = 8.0;
            double area = CalculateTriangleArea(baseLength, height);
            Console.WriteLine($"Area of the triangle with base {baseLength} and height {height} is: {area}");
        }

        public static double CalculateRectangleArea(double length, double width)
        {
            
            return length * width;
        }

        
        public static void RecTest(string[] args)
        {
            double length = 5.0; 
            double width = 3.0;  

            
            double area = CalculateRectangleArea(length, width);
            Console.WriteLine($"Area of the rectangle with length {length} and width {width} is: {area}");
        }
        

    }
}
