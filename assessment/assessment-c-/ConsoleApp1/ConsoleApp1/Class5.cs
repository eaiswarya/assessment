using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
public abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
    public void DisplayResult()
    {
        Console.WriteLine("Area:{CalculateArea()}");
        Console.WriteLine("Perimeter:{CalculatePerimeter()}");


    }

}
public class Circle : Shape
{
    private double Radius { get; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double CalculateArea()
    {

        return Math.PI * Radius * Radius;
    }
    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;

    }
}
public class Rectangle : Shape
{
    private double Width { get; }
    private double Height { get; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public override double CalculateArea()
    {
        return Width * Height;
    }
    public override double CalculatePerimeter()
    {
        return 2 * (Height + Width);
    }
}
public class Triangle : Shape
{
    private double SideA { get; }
    private double SideB { get; }
    private double SideC { get; }
    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double CalculateArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }
    public override double CalculatePerimeter()
    {
        return SideA + SideB + SideC;
    }
}
class Display
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(5);
        Console.WriteLine("Circle:");
        circle.DisplayResult();

        Shape rectangle = new Rectangle(4, 6);
        Console.WriteLine("\nRectangle:");
        rectangle.DisplayResult();

        Shape triangle = new Triangle(3, 4, 5);
        Console.WriteLine("\nTriangle");
        triangle.DisplayResult();
    }
}
}

