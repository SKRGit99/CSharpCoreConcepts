using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class AccessSpecifiersInheritance: AccessSpecifiersEncapsulationUsingProperties
    {

        /* 

            AccessSpecifiersUsingInheritance inherits AccessSpecifiersEncapsulationUsingProperties.

            AccessSpecifiersEncapsulationUsingProperties = Parent Class.

            AccessSpecifiersUsingInheritance = Child Class.

            Benefits of Inheritance is that we can directly start Consuming protected, internal, protected internal fields of the Parent class into Child Class Methods.

            Very Important Point:
        
            We can not use them as Local variabels of the Child Class.

            _schoolName = ""; - - This will not exist in the Currrent context.

            But same fields from Parent Class can be directly used in the Child Class 'Methods' as shown below.


            What about Private fields from Parent Classes?
            The Private fields of the Parent Class can be accessed here in the Child Class through Calling the Base Class Methods.

            Example: In base Class, acccessPrivateFieldsOfParentClassInChildClass method uses multiple Private fields.

            We can define a method here and call this Parent Class method and display the same Private Fields in Child Class. 

         */


        public void accessParentClassPropertiesInChildClass()
        {
            /*
                First run this method without assigning values to the properties which have been inherited from Parent Class.
             
                Then run the code after assigning values to the same inherited properties.

                The difference is that we can indeed inherit the properties but we have to assign their values afresh else they will show default values in Child Class.
             
                Point to remember: We do not inherit the assigned values to these properties but only the fields itself.

             */

            Console.WriteLine("Access Specifier for these Properties in their Parent/Base classes are: SchoolName - public, EstablishedYear - protecetd, IsSchoolRegistered - internal, RegistrationNumber - Protected, SchoolPhoneNumber - public ");
            Console.WriteLine("We can access the such fields into the Child class Methods directly.");
            Console.WriteLine($"School Name : {SchoolName} School establishment year is: {EstablishedYear} Is School Registered : {IsSchoolRegistered} Registration number : {RegistrationNumber} school phone number : {SchoolPhoneNumber} ");

            
            SchoolName = "ABC International School";
            EstablishedYear = DateOnly.FromDateTime(new DateTime(2020,2,2));
            IsSchoolRegistered = 'Y';
            RegistrationNumber = "1008CBSEEST";
            SchoolPhoneNumber = 8888888888;

            Console.WriteLine("Assigned values to the Parent Class Properties.");

            Console.WriteLine($"School Name : {SchoolName} School establishment year is: {EstablishedYear} Is School Registered : {IsSchoolRegistered} Registration number : {RegistrationNumber} School Phone Number : {SchoolPhoneNumber} ");

        }

        

        public void accessParentClassPrivateFieldsDirectlybyMethodCalling()
        {

            acccessPrivateFieldsOfParentClassInChildClass(); // Called the Base Class method directly. We can now accesss and display Private fields of the Base Class here as well.
            
        }

        public void accessParentClassPropertiesViaParentClassObjectCreation( long schPhoneNumber, string schName)
        {
            SchoolPhoneNumber = schPhoneNumber;
            SchoolName = schName;

            Console.WriteLine("Assigned Parent Class values to the Child Class fields via creating an object of the Parent Class");
            Console.WriteLine($" School Name : {SchoolName} Establishment Year : {EstablishedYear} School Phone Number : {SchoolPhoneNumber} ");

        }


        static void Main(string[] args)
        {
            
                AccessSpecifiersInheritance acc01 = new AccessSpecifiersInheritance();
                
                acc01.accessParentClassPropertiesInChildClass();

                acc01.accessParentClassPrivateFieldsDirectlybyMethodCalling(); //Parent Class method directly called using an Object of the Child Class.


                //Parent Class property directly accessed using an Object of the Child Class.
                acc01.SchoolID = 40; // Protected Property in Parent Class.

                acc01.SchooolCode = "ABCPAT04"; // Protected Property in Parent Class.
                
                acc01.IsSchoolRegistered = 'N'; 

                AccessSpecifiersEncapsulationUsingProperties accParent = new AccessSpecifiersEncapsulationUsingProperties();





            /*
                Here in this second approach we will first create an object of Parent class and the use that Parent Class object to fetch the Parent Class fields and Properties.

                But we will not be able to fetch fields with access specifiers as Private or Protected even through object creation?

                
                [Case 1] Example: School id and School Code are Private fields.

                Can we access them here using Object creation?
                Answer: No.

                accParent._schoolID = 12345;
                
                It will throw Error.

                [Case 2] Example: EstablishedYear and RegistrationNumber are Protecetd Properties.

                Protecetd Properties can not be accessed in child class through Object creation of Parent Class as well.

                Let's try to access Protected fields 'directly' using 'Object creation'?

                accParent.EstablishedYear       //This will throw error.

                accParent.RegistrationNumber    //This will throw error.

                

                If we can not fetch Protected Properties from Parent Class directly via their object creation into the Child Class, then How can we bring them in this Child Class?

                Simple answer is: we know they can be accessed in Child Class only in 'Methods' as shown above in accessParentClassPropertiesInChildClass().

                Summary:  We can not access Private 'fields' and Protected 'Properties' of Parent Classes in the Child Class directly through Object creation.
                          
                          We can access the Protecetd Properties via Methods in Child Classes only.

                          We can access and display Private fields only through calling a Parent Class method that displays Private fields in Parent Class itself.

                          We can directly access rest like Internal, Protected internal and Public Properties of Parent Class through its object creation in Child Class.
                
            */


                accParent.SchoolName = "ABC International School - Patna"; // Base Class Public Property : accessible.
                accParent.IsSchoolRegistered='Y'; // Base Class Internal Property : accessible.
                //accParent.EstablishedYear = DateOnly.FromDateTime(new DateTime(2020,3,3)); // Base Class protected field : Not accessible.
                accParent.SchoolPhoneNumber = 8888888888; // Base Class Public Property : accessible.



            /*
                Private fields Not accessible here in the Child Class as Private members can not be accessed outside the Class.

                We are not able to access it here in the Child Class.
                So,All those Member methods having "Private" access specifier can not be consumed directly Outside that Class.


                *void accessPrivateMethodsOfParentClassInChildClass()
                we are not able to access it here in the Child Class.

                So All those Member methods having "Private" access specifier can not be consumed Outside that Base Class.
            
                
                Non-Private Properties:

                Protected : Accessible inside the Child class int Child Class Methods.

                Internal, protected internal and Public are accessible inside the Child class int Child Class Methods. 
  

            */


            acc01.accessParentClassPropertiesViaParentClassObjectCreation(accParent.SchoolPhoneNumber,accParent.SchoolName);

            Console.ReadKey();

        }



    }

}

