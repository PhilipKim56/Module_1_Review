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


        //public static void CirTest(string[] args)
        //{
        //    double radius = 5.0;
        //    double area = CalculateCircleArea(radius);
        //    Console.WriteLine($"Area of the circle with radius {radius} is: {area}");
        //}




        public static double CalculateTriangleArea(double baseLength, double height)
        {

            double area = 0.5 * baseLength * height;
            return area;
        }


        //public static void TriTest(string[] args)
        //{
        //    double baseLength = 5.0;
        //    double height = 8.0;
        //    double area = CalculateTriangleArea(baseLength, height);
        //    Console.WriteLine($"Area of the triangle with base {baseLength} and height {height} is: {area}");
        //}

        public static double CalculateRectangleArea(double length, double width)
        {

            return length * width;
        }


        //public static void RecTest(string[] args)
        //{
        //    double length = 5.0; 
        //    double width = 3.0;  


        //    double area = CalculateRectangleArea(length, width);
        //    Console.WriteLine($"Area of the rectangle with length {length} and width {width} is: {area}");
        //}

        public static double CalculateSquareArea(double side)
        {

            return side * side;
        }


        //public static void SquTest(string[] args)
        //{
        //    double side = 4.0;


        //    double area = CalculateSquareArea(side);
        //    Console.WriteLine($"Area of the square with side {side} is: {area}");
        //}

        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a shape:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("4. Square");

            
            Console.Write("Enter your choice (1-4): ");
            int choice = int.Parse(Console.ReadLine());

            double area = 0.0;

            switch (choice)
            {
                case 1: 
                    Console.Write("Enter the radius of the circle: ");
                    double radius = double.Parse(Console.ReadLine());
                    area = CalculateCircleArea(radius);
                    break;
                case 2: 
                    Console.Write("Enter the base length of the triangle: ");
                    double baseLength = double.Parse(Console.ReadLine());
                    Console.Write("Enter the height of the triangle: ");
                    double triangleHeight = double.Parse(Console.ReadLine());
                    area = CalculateTriangleArea(baseLength, triangleHeight);
                    break;
                case 3: 
                    Console.Write("Enter the length of the rectangle: ");
                    double rectLength = double.Parse(Console.ReadLine());
                    Console.Write("Enter the width of the rectangle: ");
                    double rectWidth = double.Parse(Console.ReadLine());
                    area = CalculateRectangleArea(rectLength, rectWidth);
                    break;
                case 4: 
                    Console.Write("Enter the side length of the square: ");
                    double squareSide = double.Parse(Console.ReadLine());
                    area = CalculateSquareArea(squareSide);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            

            Console.WriteLine($"The calculated area of the chosen shape is: {area}");
        }
    }
}
