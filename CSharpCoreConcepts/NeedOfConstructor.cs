using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class NeedOfConstructor
    {
            /*
                Every Class needs a Constructor in it so that an Instance of Class can be created
                Every Class has an Implicit Constructor defined by the Compiler if at all an Explicit Constructor is not defined by the Programmer.
                So ,If a Class has an Implicit Constructor then what is the need of an Explicit Constructor?
                Implicit Constructors of a Class will initialize Variables of a Class with the 'same value' even if we create Multiple Instances of that Class.
        
             */

                public int ImplicitVal = 100;
    }

    class ExplicitConstructors
    {
                public int ExplicitVal;
                public ExplicitConstructors(int val)
                {
                    this.ExplicitVal = val;

                    /*this.ExplicitVal refers to the 'Class Variable' ExplicitVal */
                }
    }

    class ExecuteNeedOfConstructors
    {
        static void Main(string[] args)
        {
            /*

                Here No Matter we create any number of Instances of the Class but everytime Implicit Constructor will Initialize the same Value
                So even if we have created three instances meaning three Different Memory Allocations being made but all of them have the same Value.

            */

                NeedOfConstructor need1 = new NeedOfConstructor();
                Console.WriteLine(need1.ImplicitVal);

                NeedOfConstructor need2 = new NeedOfConstructor();
                Console.WriteLine(need2.ImplicitVal);

                NeedOfConstructor need3 = new NeedOfConstructor();
                Console.WriteLine(need3.ImplicitVal);


            /*

                Hence if we define Constructors Explicitly with Parameters then we get a chance of initializing 
                fields or Variables with New Values every time we are creating a new Instance of a Class.
                Here because of Explicit Constructors we are able to create three Instances meaning three different Memory allocations
                but with Different Values.

            */

                ExplicitConstructors ex1 = new ExplicitConstructors(100);
                Console.WriteLine(ex1.ExplicitVal);
                ExplicitConstructors ex2 = new ExplicitConstructors(200);
                Console.WriteLine(ex2.ExplicitVal);
                ExplicitConstructors ex3 = new ExplicitConstructors(300);
                Console.WriteLine(ex3.ExplicitVal);

            /*
                Hence Whenever we define a Class first Identify whether the Class Variables need some values to execute 
                and if they do require some values to execute then define a Constructor Explicitly and pass Values through that
                Constructor ,so that every time we create an Instance of the Class , We get a chance to pass New Values.
                
                Note : Generally Every Class requires some values for Execution and the Values are always sent to that Class through the 
                Constructor only. 

            */
        }

    }


}
