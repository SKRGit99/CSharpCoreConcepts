using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace CSharpCoreConcepts
{
    public class OmTest
    {
        public void printName()
        {
            OmDemo DemoOm = new OmDemo();
            DemoOm._description = "This is my Name";
            Console.WriteLine("Name is Om" + DemoOm._description);
        }

        static void Main(string[] args)
        {
            OmTest demo = new OmTest();
            demo.printName();
        }

    }

    public class CalculateArea
    {


        public decimal _radius;
        public decimal _areaOfCircle;

        public decimal _sideOfSquare;
        public decimal _length;
        public decimal _breadth;
        public decimal sideOfTriangle;


        public void CalculateAreaOfCircle()
        {
            _radius = 7;
            // _areaOfCircle = (22 * _radius * _radius) / 7;

            _areaOfCircle = (decimal)Math.PI * _radius * _radius;

            Console.WriteLine("Area of Circle: " + _areaOfCircle);



        }




    }


    public class DisplayArea
    {
        public void displayAreaOfCircle()
        {


            CalculateArea calArea = new CalculateArea();
            calArea.CalculateAreaOfCircle();

        }

        static void Main(string[] args)
        {
            DisplayArea disArea = new DisplayArea();

            disArea.displayAreaOfCircle();


        }


    }


    public class calculateAreaOfGeometricalStructures
    {
        public void Circle(double radius)
        {
            double area = 3.14 * radius * radius;
            Console.WriteLine("Circle Area: " + area);
        }

        public void Square(double side)
        {
            double area = side * side;
            Console.WriteLine("Square Area: " + area);
        }

        public void Rectangle(double length, double width)
        {
            double area = length * width;
            Console.WriteLine("Rectangle Area: " + area);
        }

        public void Triangle(double baseLength, double height)
        {
            double area = 0.5 * baseLength * height;
            Console.WriteLine("Triangle Area: " + area);
        }

        public void EquilateralTriangle(double side)
        {
            double area = (1.732 / 4) * side * side; // √3 ≈ 1.732
            Console.WriteLine("Equilateral Triangle Area: " + area);
        }
    }

    public class PrintArea
    {
        static void Main(string[] args)
        {

            calculateAreaOfGeometricalStructures cal = new calculateAreaOfGeometricalStructures();
            cal.Circle(7);
            cal.Square(7);
            cal.Rectangle(8, 8);
            cal.EquilateralTriangle(16);
            
        }
    }

}









