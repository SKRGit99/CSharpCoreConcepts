using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    /*
    Topics Covered: 

    [a] what are 'using' statemnets?
    [b] what is a namespace?
    [c] what is .NET?
    [d] what is c#? Features of C#.
    [e] what is Visual Studio IDE
    [f] difference between Project and Solution
    [g] steps to execute code

*/

    /* 
    
      [a] what are using statemnets?
          using System;
          using System.Collections.Generic;
          using System.Linq;
          using System.Text;
          using System.Threading.Tasks;

          These "using" Statements are "Importing Namespaces"/ Inbuilt libraries given by Microsoft.
          In the Library of Our Language i.e. "Base Class Libraries",there are so many pre-defined Classes and 
          All those classes are defined under Some namespaces.
          Hence, To Consume those classes in our Code,we need to import those Namespaces.
          e.g. 'System' Namespace has hundreds of Classes defined under it and it is important for us to use these Namespaces.
          System and various other packages here actually provide us the ability to import classes predefined under them.

    */

    /*
        [b] what is a namespace?
            namespace is a 'logical' Container of 'Types'.
            It is called Logical Container because it does not have a Physical Existence.
            Generally we use it for Grouping the Items. 
            e.g. Folders in our Operating Systems are Containers for Storing Files.
            Files have Physical Existence but are grouped inside Folders.
            Similarly Our .NET Programming Languages are provided with Logical Containers called 'Namespace'.
            Suppose we have Ten Classes in our Project, we can group it into Two Containers.

            So we can group five-five classes under Two Namespaces.
            By default the name of Namespace is Project name itself but we can change that also.

    */

    /*
            [c] What is .NET ? 
                According to Microsoft,we do not have a full form for this .NET and 
                also we do not have any standard definition for this Particular .NET

                It is a technology provided by microsoft to build various types of applications.
                Applications may be -- Desktop Applications, Web Applications, and Mobile Applications.

                Unfortunately the problem with Older Programming languages like C,C++ is that we can not 
                use the same language for developing different types of Applications.
                We are going to need different languages to build different Applications.

                Hence came .NET into picture as with .NET we can develop Desktop Applications,Web Applications and Mobile Applications.

                Under .NET, Microsoft has provided a set of Programming Languages like there are officially "Thirty plus languages" in .NET

                Microsoft has basically provided developers with Different background to use these Languages and build Applications.
                e.g. For C/C++ background Developers ,Microsoft has provided C#.
                Other examples are F# .NET,J# .NET, VB .NET etc.

            [d] Features of C#
                    -> It is Object Oriented.
                    The main strength of Object Oriented Programming is "Security" and "ReUsability".

                    -> It is Platform Independent.
                    i.e. The Applications dveloped on C# can be run on multiple Platforms.
                    e.g. The Current Version of .NET ,there is "direct" support for building our 
                    C# Applications to run on Windows, Android Phones as well as IPhones.

                    -> Language Independent.
                    C# Code can be reused in all the Thirty plus languages under .NET 

                    -> C# is Case Sensitive.

            [e] Visual Studio .NET IDE
                    It is an IDE that has been provided by Microsoft for developing .NET Applications.
                    IDE stands for "Integrated Development Environment"
                    e.g. For working with C Language we have TurboC IDE.
                    Similarly for developing .NET Applications we have Visual Studion IDE.

                *Visual Studio IDE provides support for Every type of Application.
                    e.g. It will provide support for developing Console Applications,Windows Applications,Web Applications, Web Services etc.

            [f] difference between Project and Solution
                We shall start with a Console Application - Console application is a Basic appllication. It only contains the Middleware entrypoint for the application.
                Console application is not a Architectural based/ Pattern based application.
                The difference between Project and Solution.

                Solution Explorer
                ================
                Solution Explorer is actually a collection of various projects.
                Solution Explorer can have one or more than one Projects.
                Solution Explorer Window gives us the Entire Application.
                So, Soltion Explorer is the "Root" Element under which we have Projects.

                Project
                =======
                It is collection of Items.  
                e.g. Classes,Interfaces,Structutes,Enums,Delegates,Windows Forms,Web Forms etc.
                When we create any project e.g.Console Project here.
                it will have a default "Program.cs" Class file.

        

             [g] steps to execute code
                    Use Ctrl+F5 to execute -> It will save,compile and execute our code.

       */

    internal class CSharpIntroduction
    {
        public void definitionOfNameSpace()
        {
            Console.WriteLine("This is the Introduction Class for CSharp OOPS Concepts and .NET Core");
            Console.WriteLine("Concepts covered: using Statements");
            Console.WriteLine("namespace");
            Console.WriteLine("definition of .NET");
            Console.WriteLine("features of C#");
            
        }

        public void DifferencebetweenReadKeyReadLine()
        {
            Console.WriteLine("This is method calling for ReadLine");
            Console.ReadLine();


        }

        public void DifferencebetweenReadKeyReadLine1()
        {
            Console.WriteLine("This is method calling for ReadKey");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            CSharpIntroduction introclass = new CSharpIntroduction();
            introclass.definitionOfNameSpace();
            introclass.DifferencebetweenReadKeyReadLine();

            /*
              After using ReadLine(), The next Method DifferencebetweenReadKeyReadLine1() will not be called.

            */

            introclass.DifferencebetweenReadKeyReadLine1();
        }

    }
}
