using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace CSharpCoreConcepts
{
    public class CodeDemo002
    {
        public void printName()
        {
            CodeDemo001 DemoOm = new CodeDemo001();
            DemoOm._description = "This is my Name";
            Console.WriteLine("Name is Om" + DemoOm._description);
        }

        static void Main(string[] args)
        {
            CodeDemo002 demo = new CodeDemo002();
            demo.printName();
        }

    }

    public class CalculateAreaOfGeometricalStructures
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


    public class DisplayAreaOfGeometricalStructures
    {
        public void displayAreaOfCircle()
        {


            CalculateAreaOfGeometricalStructures calArea = new CalculateAreaOfGeometricalStructures();
            calArea.CalculateAreaOfCircle();

        }

        static void Main(string[] args)
        {
            DisplayAreaOfGeometricalStructures disArea = new DisplayAreaOfGeometricalStructures();

            disArea.displayAreaOfCircle();


        }


    }

    public class PrintArea
    {
        static void Main(string[] args)
        {

            CalculateAreaOfGeometricalStructures cal = new CalculateAreaOfGeometricalStructures();
            cal.CalculateAreaOfCircle();
            // cal.Square(7);
            // cal.Rectangle(8, 8);
            // cal.EquilateralTriangle(16);
            
        }
    }

}









