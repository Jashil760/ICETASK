using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task
{

    public class Shape
    {
        public abstract double Area();
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius) 
        {
            this.radius = radius;
        }

        public override double Area() 
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Rectangle : Shape
    {
        private double height;
        private double Base;

        public Rectangle(double height, double Base)
        { 
            this.height = height;
            this.Base = Base;

            public override double Area()
            {
            return Base * height;
            }
        }

    public class Triangle : Shape
    {
        private double baselength;
        private double height;

        public Triangle(double baselength, double height)
        { 
            this.baselength = baselength;
            this.height = height;
        }
        public override double Area()
        { 
            return 0.5 * baselength * height;
        }

    }
    
    
    public class Square : Shape
    {
        private double length;

        public Square(double length)
        { 
            this.length = length;
        }
        public override double Area()
        { 
            return length*length;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        Shape[] sh = { new Circle(5), new Rectangle(4, 6), new Triangle(3, 8),new Shape(7) };
        foreach (Shape shape in sh)
        { 
            Console.WriteLine("Area of shape: " + shape.Area());
        }
        Console.ReadKey();
        }
    }
}
