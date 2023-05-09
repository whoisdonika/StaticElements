﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassGeometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side: ");
            double side = double.Parse(Console.ReadLine());
           
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
           
            double squarePerimeter = Geometry.SquarePerimeter(side);
            double squareArea = Geometry.SquareArea(side);
            double rectanglePerimeter = Geometry.RectanglePerimeter(a, b);
            double rectangleArea = Geometry.RectangleArea(a, b);
            double circleArea = Geometry.CircleArea(radius);
            
            Console.WriteLine($"Square: perimeter = {squarePerimeter}, area = {squareArea}");
            Console.WriteLine($"Rectangle: perimeter = {rectanglePerimeter}, area = {rectangleArea}");
            Console.WriteLine($"Circle: area = {circleArea}");

        }
    }
}
