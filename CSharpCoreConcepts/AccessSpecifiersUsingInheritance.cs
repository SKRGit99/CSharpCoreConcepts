using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class AccessSpecifiersUsingInheritance: AccessSpecifiersIntroduction
    {

        /* 

            AccessSpecifiers01 inherits AccessSpecifiers 
            Case: 2 -  Where we will see Consuming members of the Child Class after accessing members from the Parent class in the Same Project using Inheritance. 

            *private void displaySchoolDetails()
            we are not able to access it here in the Child Class.
            So All those Member methods having "Private" access specifier can not be consumed Outside that Class.


         */




        static void Main(string[] args)
        {
            /*  Here AccessSpecifiers01 Class is inheriting from the Base Class AccessSpecifiers.*/

            AccessSpecifiersUsingInheritance acc01 = new AccessSpecifiersUsingInheritance();


            /*
                Access to Member fields and Methods of the Parent Class in the Child Class.
                We have the following Member fields and Methods inside the Parent Class.
            */


            /*
                Member fields:

                char isSchoolRegistered; 
                int rollNumber;
            
                Private fields: not acccessible.

                Private methods:
                private void displaySchoolDetails()

                acc01.displaySchoolDetails;
                
                Private Method: not accessible.
                
                Private fields and Members Not accessible here in the Child Class as Private members can not be accessed outside the Class.
                we are not able to access it here in the Child Class.
                So,All those Member methods having "Private" access specifier can not be consumed Outside that Class.
            */



            /*
                Protected,Internal,Protected internal and Public are accessible ouside the class in the Child Class. 
                establishedYear, studentName - Internal - accessible
                schoolLocation, studentCity - protected - accessible
                schoolPhoneNumber,studentPhoneNumber - protected internal - Not accessible
                schoolName,studentClass,classSection registeredStudent - Public - accessible 

            */

            acc01.displayStudentResult();
            /*
                protected void displayStudentResult()
                It is acccessible here.
                It means methods having Protected access specifier is accessible ouside that Class.
            */

            acc01.displayClassTeacherDetails();
           
            /*
                protected internal void displayClassTeacherDetails() 
                It is accessible here so Methods having protected internal access specifier is accessible outside that Class.
            */


            acc01.displayStudentDetails();
            /*
                internal void displayStudentDetails() 
                It is accessible here so Methods having Internal access specifier is accessible outside that Class.
            */


            acc01.displaySchoolContactDetails();
            /*
                public void displaySchoolContactDetails()
                public methods are accessible anywhere.
             
            */




            Console.ReadKey();

        }



    }

}

