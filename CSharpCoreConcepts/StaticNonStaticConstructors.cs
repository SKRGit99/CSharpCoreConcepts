using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class StaticNonStaticConstructors
    {
        /*
            Static Constructor : If a Constructor is explicitly declared with a "static" Modifier ,we call that Constructor as a Static Constructor
            whereas rest of other are Non Static/Instance Constructors only.

            'Static' Fields are initialzed by Static Constrcutors and 'Non-static' fields are initialized by Non-Static Connstructors.

            Static Constructors are Implicitly Called where as Non-Static Constructors are Explicitly Called.

            Static Constructors execute immediately after the execution of the Class starts.

            More Over , It is the 'first blcok of Code' to run under the Class whereas Non-Static Constructors execute only after creating the Instance of the Class
            as well as everytime an Instance of Class is created.

            In the Life Cycle of the Class, the Static Constructors execute one and 'only one time' where as Non-Static Static Constructors are executed
            'as many times' as the Instances of the Class is created.

            Static Constructors can not have any Parameters while Non-Static Constructors can be Parameterized.

            Since Static Constructors are called Implicitly i.e. Values can not be sent to it also 
            as the First blcok of Code to be executed ,so there is no chance that we can pass any Parameters.

            Static Constructors can not be Overloaded while Non-Static Constructors can be Overloaded.
            We know that Overloading comes into Picture because of Parameters so if Static Constructors are Parameterless
            then there is No Question of it being Overloaded.

            Every Class Contains an Implicit Constructor if Not defined Explicitly and those Implicit Constructors are defined based on the following Criteria.

            Note:   Every Class except a Static Class Contains an Implicit Non-Static Constructor if not defined with an Explicit Constructor.

                    Static Class means a Class declared using a Static Modifier and Can Contain "Only" Static Members in it.

                    So We can not have a Non Static Constructor also inside a Static Class as it contain only Static Members.

            Static Constructors are implicitly defined 'only' if that Class contains 'Any Static' fields or else that Constructor will not be present at all.
            i.e. No static field means No Static Constructor also.

            Constructors are responsible for initializing the fields or Variables of the Class.





        */


                int rollNumber;
        /*
                This Non-Static field will be initialized by Non-Static Constructor
                Also these Fields have default values.
         
        */

                static int classNumber;
        /*
                This is a Static field to be initialized by Static Constructor. 
         
        */

                static StaticNonStaticConstructors()
                {
                    Console.WriteLine("Static Constructor is Called Implicitly.");
                    Console.WriteLine("Main Method is not yet called still the Static Variables get initialized.");
                    Console.WriteLine("The value of static field 'classNumber' is:" + classNumber);

                }

                public StaticNonStaticConstructors()
                {
                    Console.WriteLine("Non-Static/Instance Constructors is called.");
                }

                static void Main()
                {
                    Console.WriteLine("Main Method is now called.");
                    //Console.ReadLine();
                
                    /*

                        Here see that we have not created an Instance and called the static Constructor but still the Static Constructor is Called Implicitly.

                        See the Output even before the Main Method is executed and 'Main Method is not yet called' is printed, even before the Execution of the Main Method,
                        The Static Constructor is called and prints the Line of the Static Constructor.

                        Thus, it has been proved that Static block is the first block of code to be executed once the Class execution starts.

                    */

                        StaticNonStaticConstructors statNonstat = new StaticNonStaticConstructors();
                        StaticNonStaticConstructors statNonstatone = new StaticNonStaticConstructors();
                        StaticNonStaticConstructors statNonstatTwo = new StaticNonStaticConstructors();

                    /*
                     
                        Here we have called the Non Static Constructors only explicitly.
                        Moreover therse are three different Instances of the Class,So three times the Non Static Constructor shall be called.
                        Also see that despite three Instance of the Class being created but Static Constructor is called only once during the Life Cycle of the Class.

                    */
                }

    }
}
