using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public abstract class AbstractionUsingAbstractClassesDemo
    {
        public int CalculateSalary(int baseSalary)
        {
            return 10 * baseSalary;
        }

    }

    public class AbstractionUsingAbstractClassDemo : AbstractionUsingAbstractClassesDemo
    {

        
        /*
         Without even knowing the Method details for 'CalculateSalary', we were able to abstract it in the Child Class using the Concept of Abstraction.
         
         
         
         */

        static void Main(string[] args)
        {
            AbstractionUsingAbstractClassDemo abstractDemo = new AbstractionUsingAbstractClassDemo();
            int sal= abstractDemo.CalculateSalary(10000);

            string? _name = "SampatKumarRahul";
            string? _firstName = _name.Substring(0,6);

            string? _lastName = _name.Substring(6);

            Console.WriteLine($"Full Name : {_name}");
            Console.WriteLine($"First Name : {_firstName}");
            Console.WriteLine($"Last Name : {_lastName}");


            Console.WriteLine($"Salary : {sal}");
        }
    }

    
}
