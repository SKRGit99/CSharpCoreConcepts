using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    internal class OOPSIntroduction
    {
        /*
         
            Kumar S.  (+91) 9148113977
            ==========================
            How .net core platform independent?
            How .net core is more secure?

            DLL / EXE

            Single tier architecture project:  Entire project in 1 DLL

            --> Minimum level is segregating our soln into files  [only 1 dll]

            --> For bigger projects we have to segregate our soln to different project  [multiple dll]


            1. Console Application : Console application is not architecture based or pattern based.

            2. Program.cs

            3. Using Statements : Importing Namespaces provided by the Base Class library of Our Language.

            4. Namespace : Logical unit for Grouping together of Types and its Members . e.g. Class is a Type and the fields inside Class are its Members.

            5. Program.cs is the Middleware entry point for the Compiler.

            6. Middleware : If you want to restrict access to code level, you can add the service and use the service here itself. e.g. Implementing Authentication and Authorization.

            7. Object : Primary source to implement what happens in code.

            8. Class : Logical unit or Blueprint that Contains all related Fields, Properties and Methods together for security reasons. 

            9. OOPS : Programming Paradigm based on the Concept of Object which includes Data and Code.

            10. 4 Foundational pillars of OOPS.

            [a] Encapsulation : Access Specifiers.
            Private > Protected > Internal > Protected Internal > Public.

            [b] Inheritance : Child Class inherits Parent Class all Non-Private fields and Methods (through Child Class Object Creation)
            Also, Child Class can display Parent Class 'Private' fields via Calling inside Child Class Method - Any such Parent Class Method that displays Parent Class Private fields.  
            child Class can directly access Parent Class Non-Private fields inside Child Class Local Methods.

            [c] Polymorphism

            [d] Abstraction : Abstract Class and Interface
 
            11. Value type Vs Reference type.

            Data type ---->  Value type   vs  Reference type
            ================================================

            Value type :  Takes a fixed memory


            byte roll  8 bit	  	1  to 255   			byte x = 848484

            long  --->   64 bit		range of data		8735367373388

            decimal --> 128 bit

   
            Reference type :   No fixed memory and no fixed range Of Data
            =============================================================

            string	-- > string name = "475765657856868695995958477477773737";
     	

            object

            12. Instance Vs reference :

            Instance  = Allocation of Memory.

            Reference = Starting Point of Address.

            Reference (Left) + Instance (Right) = Object

            StudentDetails stddet = new StudentDetails()

            This 'stddet' object gets everything belonging to Class 'StudentDetails'.
	

            Instance Vs Reference :
            ======================

            Reference: Starting point of memory location


            Builder -- > Plot example
            ========================	

            I say the builder reserve that area 4th plot onwards for me (without paying for it), It means reference.
            I have only set the starting point of my to be plot (relate with memory location).

            But after paying for it gets it allocated to me, similarly instance is when "Memory" is allocated for it.
         
         
         */
    }
}
