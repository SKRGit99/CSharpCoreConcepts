using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class ImplicitConstructor
    {
        int rollNumber;
        string studentName;
        object studentDetails;
        bool registeredStudent;

        static void Main(string[] args)
        {
            ImplicitConstructor impCons = new ImplicitConstructor();

            Console.WriteLine("Implicit Constructor method is Called.");
            Console.WriteLine("Since Implicit Constructors are parameterless so it will initialize the member Variables with their Default Values.");
            
            /* 
                On Execution of the below lines of Code.We can see the variables have been initialized to their default values i.e. 0,null,null,false;
            */

            Console.WriteLine("Roll number:" + impCons.rollNumber);
            Console.WriteLine("Student Name:" + impCons.studentName);
            Console.WriteLine("Student Details:" + impCons.studentDetails);
            Console.WriteLine("Registered Student:" + impCons.registeredStudent);
        }

        /*
            *Here the Programmer has not defined the Constructor ,But he has written code for creating an Instance of the Class.
         
            *How come this is true if we know that a Class needs a Constructor if at all it's Instance is to be created?
          
            The Answer lies in the Concept of "Implicit Contructors" which are "defined by the Compiler" if the Programmer has not explicitly defined a Constructor.

            *It is the responsibility of a Programmer to define a Constructor within his Class but if he fails to do so, an "Implicit" Constructor is defined by the Compiler.

            *It is because of Constructor that every field gets intialized in the Class.
        */

    }
}
