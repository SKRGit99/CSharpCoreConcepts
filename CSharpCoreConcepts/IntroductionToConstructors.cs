using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpCoreConcepts
{
    public class IntroductionToConstructors
    {
        /*
            Object Oriented programming is all about writing code inside a Class.
            Class is a collection of various members like 'Fields', 'Methods','Constructors' etc.
            Every field that has been declared inside a Class a Default Value.
        */

        int rollNumber;
        string nameOfStudent;
        object detailsOfStudent;
        bool registeredStudent;

        /*
            Here we have declared four Variables.
            The default value for int is '0'
            string is 'null'
            object is 'null'
            bool is 'false'


            Constructor is a special method present inside a class responsible for "initializing" the "Variables" of that Class.
            Without Constructors we can not initialize the Variables and assign a Value.
            Every class requires a Constructor to 'create an Instance' of a Class.

            If a Constructor is not available we can not create Instance of the Class
            because whenever we are going to create an Instance of a Class, we are going to call a Constructor Explicitly.
            Since it is a method, it would require a Name also.

            *Name of a Constructor Method is exactly same as that of the Class.
            *Methods are generally of Two types -> Returning Value and Non Returning Value.
            *It is a 'Non Value Returning' Method.i.e.Constructors Methods do not return any Value.
            
            *Each and Every Class requires this Constructors if we want to create an Instance of this Class.
            *Whenever we create an Instance of a Class there will be a call to the Constructor.
             e.g.If we create five Instances of the Class ,The Constructor will be explicitly called Five Times.

         
          
            public IntroductionToConstructors() 
            {
              
                rollNumber=0;
                nameOfStudent=null;
                registeredStudent=false;
                detailsOfStudent=null;

            }
        
          This is an Explicitly defined Constructor which will 'initialize the default values' to the Variables when an instance of Class is created.
          Explicitly defined Constructors can be both Parameterless and Parameterized.

          *If the Constructor is not defined Explicitly then this work would be done by the "Implicit" Constructor defined by the Compiler.
          
          *Default Constructor -> An Implicit Constructor is also called Default Constructor as Default Constructor does not take any Parameter.
           Since Constructor is a Method so it can take Parameters also but an Implicit Constructor defined by Compiler does not take any Parameter.
           Hence called 'Default Constructor'.
          
          *Implicitly defined Constructors are Parameterless and hence intialize the Variables to their Default Values. 

          *Implicitly defined Constructors are 'Public'. 
          

        */

        static void Main(string[] args)
        {

            IntroductionToConstructors demo = new IntroductionToConstructors();

            /*Remember that creating Instances of Class is basically calling the Constructor Explicitly only */
            Console.WriteLine("Value of rollNumber is :" + demo.rollNumber);
            Console.WriteLine("Value of nameOfStudent is :" + demo.nameOfStudent);
            Console.WriteLine("Value of detailsOfStudent is :" + demo.detailsOfStudent);
            Console.WriteLine("Value of registeredStudent is :" + demo.registeredStudent);


        }

        /* 
           
            On Execution of the above lines of Code.
            We can see the variables have been initialized to their default values i.e. 0,null,null,false;
        
         */


    }
}
