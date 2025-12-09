using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class ExplicitConstructor
    {
        int rollNumber;
        string? studentName;
        object? studentDetails;
        bool registeredStudent;

        public ExplicitConstructor()
        {
            Console.WriteLine("Constructor is explicitly called every time an Instance of Class is created.");
            Console.WriteLine("Explicit Constructor may be Parameterless or Parameterized.");
            Console.WriteLine("Parameterless Explicit Constructor has been Called.");
            Console.WriteLine("Since this is Parameterless Constructor so it will initialize member Variables with Default Values only.");
        }

        public ExplicitConstructor(int rollNumber, string studentName, object studentDetails, bool registeredStudent)
        {

            this.rollNumber = rollNumber;
            this.studentName = studentName;
            this.studentDetails = studentDetails;
            this.registeredStudent = registeredStudent;
        }

        /*
            * It will assign the member variables with the Input Parameters and hence We can modify the Values assigned to the member Variables through Parameterized Constructors
        */


        static void Main(string[] args)
        {
            /*Parameterless Explicit Constructor*/
            ExplicitConstructor demo = new ExplicitConstructor();
            Console.WriteLine("Roll Number:" + demo.rollNumber);
            Console.WriteLine("Student Name:" + demo.studentName);
            Console.WriteLine("Student Details:" + demo.studentDetails);
            Console.WriteLine("Registered or Not:" + demo.registeredStudent);


            /*
             *It is very important to Understand the Concepts of

             *Defining 
              It may be Implicitly or Explicitly.
              e.g. Constructors may be defined Implicitly by the Compiler or Explicitly defined by the Programmer

             *Calling
              It can not be Implicit.
              So No matter if the Constructor is defined Implicitly or Explicitly, 
              It shall be called Explicitly only when the Instance of a Class is created.


             * It is important to understand that creating an Instance is nothing but calling the Constructor explicitly only 
               no matter it is Implicitly/Explicitly defined Constructor.

               " = new ExplicitConstructorDemo() " is basically calling the Constructor Method Explicitly only. 

             *Now create multiple instances of the class and every time an instance of class is created the constructor will be called explicitly. 

            */

            /*Parameterized Explicit Constrcutors*/

            ExplicitConstructor demo1 = new ExplicitConstructor(1, "Sampat Kumar Rahul", "Foundation Batch", true);
            Console.WriteLine("Roll Number:" + demo1.rollNumber);
            Console.WriteLine("Student Name:" + demo1.studentName);
            Console.WriteLine("Student Detail:" + demo1.studentDetails);
            Console.WriteLine("Registered Or Not:" + demo1.registeredStudent);

            ExplicitConstructor demo2 = new ExplicitConstructor(2, "Mohan", "Mains Batch", true);
            Console.WriteLine("Roll Number:" + demo2.rollNumber);
            Console.WriteLine("Student Name:" + demo2.studentName);
            Console.WriteLine("Student Detail:" + demo2.studentDetails);
            Console.WriteLine("Registered or Not:" + demo2.registeredStudent);
        }


    }
}
