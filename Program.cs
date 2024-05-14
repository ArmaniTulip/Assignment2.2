using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Assignment2._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Circle, 2 for Square, or 3 for Rectangle");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalculateCircle();
                    break;
                    case 2:
                    CalculateSquare();
                    break;
                    case 3:
                    CalculateRectangle();
                    break;
                    default:
                    Console.WriteLine("Choose 1, 2, or 3.");
                    break;
            }
            //return;
        }


        static void CalculateCircle()
        {
            Console.Write("Enter radius of the circle");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle { Radius = radius };
            circle.CalculateArea();
        }



        static void CalculateSquare()
        {
            Console.WriteLine("Enter A side of the Square");
            double LengthOfSide = Convert.ToDouble(Console.ReadLine());

            Square square = new Square { LengthOfSide = LengthOfSide };
            square.CalculateArea();
        }

        static void CalculateRectangle()
        {
            Console.WriteLine("Enter Length and Width of the Rectangle");
            double length = Convert.ToDouble(Console.ReadLine());
            double width = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle { Length = length, Width = width };
            rectangle.CalculateArea();

        }
    }

    
    public enum ColorValues { Red, Green, Blue }


    public abstract class Shape
    {

        public string ShapeId { get; set; }

        public string ShapeName { get; set; }

        public string ShapeDescription { get; set; }

        public string Color { get; set; }

        public virtual void CalculateArea()
        {
            Console.WriteLine("This shape has an area. ");

        }



    }


    public class Square : Shape
    {

        public double LengthOfSide { get; set; }

        public void CalculateArea(double LengthOfSide)
        {
            Console.WriteLine("The area of a square is " + Math.Pow(LengthOfSide, 2));
        }

    }
    public class Circle : Shape
    {


        public double Radius { get; set; }

        public void CalculateArea(double radius)
        {
            Console.WriteLine("The area of a circle is: " + Math.PI * Math.Pow(radius, 2));
        }


    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public void CalculateArea(double Width, double Length)
        {
            Console.WriteLine("The area of a rectangle is: " + Width * Length);
        }
    }
       
    

        
    

}

