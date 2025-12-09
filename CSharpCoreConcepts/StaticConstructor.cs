using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpCoreConcepts
{
    public class StaticConstructor
    {
            string? studentName;
            static string? stateOfOrigin;

        /*
            
            Static Constructor is invoked only once in the Class and initializes only the Static Fields or Data of the Class. 
            It can not be called Directly.
            When It is executing then the User has no Control.
            It does not take any Access Modifiers or any Parameters.
            It is called Automatically to initialize the Class before the First Instance is created

        */


            static StaticConstructor()
            {
                Console.WriteLine("This is a Static Constructor.");
                stateOfOrigin = "Bihar";
                Console.WriteLine("State:" + stateOfOrigin);
            }

            public StaticConstructor(string Name)
            {
                this.studentName = Name;
                Console.WriteLine("This is Non Static Constructor.");
                Console.WriteLine("Name : " + studentName);
            }

            static void Main()
            {
                /* 
                 
                    Static Constructor is invoked only once before the First Instance of the Class is created 
                    So, It will print 'This is Static Constructor' only Once and then the Instances of the Classses shall be created. 


                */

                StaticConstructor sd1 = new StaticConstructor("Sampat");
                StaticConstructor sd2 = new StaticConstructor("Kumar");
                StaticConstructor sd3 = new StaticConstructor("Rahul");
            }
    }
}
