using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpCoreConcepts
{
    public class CopyConstructor
    {
        /* Variable declared but not initialized any Value. */

                string? studentName;

        /*
                In Parameterized Constructor We have have to Pass Parameters as Input values which will assign that value to Variable when we create an Instance of the Class.
                i.e Every Instance of the Class that we create will have a Separate Memory allocation and the Variables will be assigned accordingly.
                Hence, if there is a variable 'name' and when I create an Instance of the Class it will assign value to this Variable 'name'.

        */

                public CopyConstructor(string stdName)
                {
                    this.studentName = stdName; // Here the variable 'name' will be initialized the value 'Sampat'
                }
                
                

        /*
         
                Now if I have to initialize the variable name with 'Sampat' Values again, why not pass the Instance of the Class itself as an Input Parameter.
                Since this Instance of the Class has already initialized the variable 'name' to 'Sampat'.
         
                This is called the Concept of 'Copy Constructor'
                It might be very useful if the same value needs to be assigned multiple times.
         
         
         */

                public CopyConstructor(CopyConstructor obj)
                {
                    studentName = obj.studentName;
                }
                public void Display(CopyConstructor obj)
                {
                    studentName = obj.studentName;
                    Console.WriteLine(studentName);
                }

                static void Main(string[] args)
                {
                    CopyConstructor cd1 = new CopyConstructor("Sampat");

                    CopyConstructor cd2 = new CopyConstructor(cd1);

                    Console.WriteLine(cd2.studentName);
                    cd2.Display(cd2);

                }

        
    }
}
