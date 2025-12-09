using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class DefaultAndParameterizedConstructor
    {
       

        int rollNumber;
        string? studentName;
        object? studentDetails;
        bool registeredStudent;

        /*Here we have only declared the variable but not intitialized any value */

        /*  Types of constructors */

        /*
                1. Default or Parameterless Constructor

                If a Constructor method does not take any Parameter, It is called Default or Parameterless Constructor.
                These Constructors can be defined by the Programmer explicitly else it shall be defined implicitly by the Compiler provided there is no Explicit
                Constructor in the Class.

                Note : Implicit Constructors will always be Default or Parameterless.
        */
        public DefaultAndParameterizedConstructor()
        {
            Console.WriteLine("This is a Default or Parameterless Constructor.");
        }

        /*2. Parameterized constructors*/

        public DefaultAndParameterizedConstructor(int rollNumber, string studentName, object studentDetails, bool registeredStudent)
        {
            this.rollNumber = rollNumber;
            this.studentName = studentName;
            this.studentDetails = studentDetails;
            this.registeredStudent = registeredStudent;
        }

        public void DisplayName()
        {
            Console.WriteLine("Roll Number:" + rollNumber);
            Console.WriteLine("Student Name:" + studentName);
            Console.WriteLine("Student Details:" + studentDetails);
            Console.WriteLine("Registered Student:" + registeredStudent);
        }
        static void Main(string[] args)
        {
            DefaultAndParameterizedConstructor demo1 = new DefaultAndParameterizedConstructor();
            demo1.DisplayName();

            /*
                    Here this instance of the Class will invoke only the Default/Parameterless Constructor.
                    More Over this 'demo1' instance of the Class when it will call DisplayName() Method ,Since default Values for:
                    int is '0'
                    String is 'Null'
                    object is ''Null'
                    bool is 'false',so it will display these Default Values only.
             */

            DefaultAndParameterizedConstructor demo2 = new DefaultAndParameterizedConstructor(1, "Sampat", "Mains Batch", true);
            demo2.DisplayName();

            DefaultAndParameterizedConstructor demo3 = new DefaultAndParameterizedConstructor(2, "Rahul", "Foundation Batch", false);
            demo3.DisplayName();

            /*
                    Here When we create an Instance of the Class ,it will invoke the Parameterized Constructor
                    We have created two instances of the class so we must remember Two separate Memory allocations will be there for each Instance of the Class. 
                    Now when we create demo2 ,it will go and Invoke Parameterized Constructor and assign the Input values to 'rollNumber','studentName','studentDetails','registeredStudent' Variables.

                    Also DisplayName() Method for these two Instances will go and assign these values to all these Variables and display accordingly.

                    MoreOver it also proves that we can have both Parameterless as well as Parameterized Constructors in the Same Class if at all we want to.
                    *Hence, We can say that Constructors can be 'Overloaded'. 
            */


        }

    }
}
