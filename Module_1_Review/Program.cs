using System;

public class CircleCalculator
{
    
    public static double CalculateCircleArea(double radius)
    {
        
        double area = Math.PI * Math.Pow(radius, 2);
        return area;
    }

    
    public static void Main(string[] args)
    {
        double radius = 5.0;
        double area = CalculateCircleArea(radius);
        Console.WriteLine($"Area of the circle with radius {radius} is: {area}");
    }
}
