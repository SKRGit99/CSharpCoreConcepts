using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class PrivateConstructor
    {
        /* 
          
            Private Constructor is defined by a Private Keyword
            Private Constructors are used only in Classes that contains only 'Static' Members.
            It is the implementation of a Singleton Class.
            Using Private Constructor prevents the creation of Instance of a Class.

       */

            static string? nameOfSchool;
            static string? addressOfSchool;

            private PrivateConstructor()
            {
                /*Since We can not create an Instance of the Class We can not access the Constructor*/
                Console.WriteLine("Private Constructor is Initialized.");
                Console.WriteLine("nameOfSchool" + nameOfSchool);
                Console.WriteLine("address" + addressOfSchool);
            }


            static void Main(string[] args)
            {
                /*Here we can aceess the Variables without creating the Instance of the Class*/

                PrivateConstructor.nameOfSchool = "Gyan Sheela";
                PrivateConstructor.addressOfSchool = "Patna Bihar";

                Console.WriteLine(nameOfSchool);
                Console.WriteLine(addressOfSchool);
            }

    }
}
