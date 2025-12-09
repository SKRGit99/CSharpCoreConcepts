using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class IntroductionToMainMethod
    {
        /*
                Here also we have defined one 'Main()' Method.
                Main method is actually an entry point.
                Main method is already defined in Program.cs.
                Since one project can have "Only One" Entry point, Hence we need to go and tell Visual Studio which Class we want to execute 
                i.e.Main() Method.

                For this Go to -> Solution Explorer -> Properties -> Double Click -> StartUp Object -> Choose the Start Up Object -> F5
        
                *StartUp Object - It contains list of all the Classes which have Main() method in it.
                Hence,remember that Without a 'Main()' method, we can not set up a StartUp Project.

                Below line of code will throw an error because instead of  "Main()" if we write  "main()" then error will be displayed.
                *we must remember C# is "Case Sensitive"

                static void main(string[] args)
                {
                Console.WriteLine("C# is Case Sensitive");
                }

             

        */

                public void explainMainMethod()
                {
                    Console.WriteLine("This is the explanation to the Main method.");
                    //Console.ReadLine();
                }
                static void Main(string[] args)
                {
                    Console.WriteLine("This is Demo for Setting StartUp Object for the Main Method Execution");
                    IntroductionToMainMethod mainMethod = new IntroductionToMainMethod();
                    mainMethod.explainMainMethod();
        }















    }
}
