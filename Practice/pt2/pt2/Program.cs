// See https://aka.ms/new-console-template for more information

using System;

namespace AdvanceCSharpProgram
{
    class Shape
    {
        public virtual void DisplayArea()
        {
            Console.WriteLine("Area Of The Shape Is Not Defined.");
        }
    }

    class Circle : Shape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override void DisplayArea()
        {
            double area = Math.PI * Radius;
            Console.WriteLine($"Area Of The Circle : {area:F2}");
        }
    }

    class Rectangle : Shape
    {
        public double Length;
        public double Width;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override void DisplayArea()
        {
            double area = Length * Width;
            Console.WriteLine($"Area Of Rectangle : {area:F2}");
        }

        public double CalculatePerameter()
        {
            return 2 * (Length + Width);
        }
    }

    class Program
    {
        static void Main(String[] s)
        {
            try
            {
                int intNumber = 100;
                double doubleNumber = intNumber;
                Console.WriteLine($"Implicit Casting (int to double) : {doubleNumber}");

                double anotherDouble = 123.43;
                int castedInt = (int)anotherDouble;
                Console.WriteLine($"Explicit Casting (double to int) : {castedInt}");

                string strNumber = "456";
                int parsedNumebr = int.Parse(strNumber);
                Console.WriteLine($"Parsed Number: {parsedNumebr}");

                string strDouble = "789.65";
                double convertedDouble = Convert.ToDouble(strDouble);
                Console.WriteLine($"Converted Double : {convertedDouble}");

                Shape shape = new Shape();
                Shape circle = new Circle(5.4);
                Shape rectangle = new Rectangle(10.0, 20.0);

                Console.WriteLine("\nShape Areas:");
                shape.DisplayArea();
                circle.DisplayArea();
                rectangle.DisplayArea();

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error:Division By Zero Is Not Allowed...! ");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid Input Format : Please Enter Valid Number...!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error : {ex.Message}");
            }

            finally
            {
                Console.WriteLine("\nProgram Execution Completed.");
            }
        }
    }
}