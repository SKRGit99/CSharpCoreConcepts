using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class AccessSpecifiersIntroduction
    {
        /* 
                
                Modifiers: All the keywords are generally known as Modifiers. e.g.  Static,
                                                                                    Public,
                                                                                    Private,
                                                                                    Virtual,
                                                                                    Override,
                                                                                    Abstract etc.
                
                Access Specifiers: These are special kind of "Modifiers" with the help of which we can define the "Scope" of a "Type" and its Members.

                Type and its Members: Type is Class and it's fields are its Members.
                
                Scope: It simply means accessibility or visibility. i.e. Who can consume and Who can not.
                
                C# supports Five types of Access Specifiers:
                
                    Private :   Accessible only within the Class in which it is defined.
                                By default the scope of Every "member" in a Class is Private.
                                We can not declare Private on "types".
                                e.g. We can not declare Class as Private.
                    
                    Internal :  A member declared Internal is accessible only within the Project in Child Class as well as Non Child Class.
                                It shall not be accessible from Outside the Project.

                    Protected : Child Class is accessible but Non Child Class i.e. Without Inheritance Not accessible Outside the Class.
                            MoreOver , Classes can not be declared Protected as we have seen earlier.
                
                    Protected - Internal:
                
               
                    Public: If a Type is declared as "public" ,It simply means accessible from anywhere.
        
         */


        char isSchoolRegistered; /* Since No Access Specifier is explicitly defined so by default is will be "Private" */
        protected string schoolLocation = string.Empty;
        protected internal long schoolPhoneNumber;
        internal int establishedYear;
        public string schoolName = string.Empty;


        int rollNumber = 0; /* Since No Access Specifier is explicitly defined so by default is will be "Private" */
        protected string studentCity = string.Empty;
        protected internal long studentPhoneNumber;
        internal string studentName = string.Empty;
        public int studentClass;
        public char classSection;
        public bool registeredStudent;


        public string classTeacherName = string.Empty;
        internal long classTeacherPhoneNumber;


        int mathsMarks;
        int scienceMarks;
        int englishMarks;
        int hindiMarks;
        int socialScienceMarks;
        int totalMarks;

        private void displaySchoolDetails()
        {
            schoolName = "ABC School";
            establishedYear = 2010;
            schoolLocation = "Delhi";
            schoolPhoneNumber = 9999999999;
            isSchoolRegistered = 'Y';
            Console.WriteLine("Private Access Specifier: Can be accessible only in this Class");
            Console.WriteLine($"School Name : {schoolName} Establishment Year : {establishedYear} Address : {schoolLocation} Contact details : {schoolPhoneNumber} Registered School : {isSchoolRegistered}");
        }

        protected void displayStudentResult()
        {
            if (studentName == "Rahul")
            {
                mathsMarks = 90;
                scienceMarks = 80;
                englishMarks = 85;
                hindiMarks = 75;
                socialScienceMarks = 70;
                totalMarks = mathsMarks + scienceMarks + englishMarks + hindiMarks + socialScienceMarks;
            }
            Console.WriteLine("Protected Access Specifier: Can be accessible only in the Child Class");
            Console.WriteLine($"Maths : {mathsMarks} Science : {scienceMarks} English : {englishMarks} Hindi : {hindiMarks} Social Science : {socialScienceMarks} Total Marks : {totalMarks}");


        }

        protected internal void displayClassTeacherDetails()
        {
            studentClass = 10;
            classSection = 'A';
            if ((studentClass == 10) && (classSection == 'A'))
            {
                classTeacherName = "Mr. Ramesh";
                Console.WriteLine("Protected Internal access speccifier:");
                Console.WriteLine($"Class : {studentClass} Class Teacher Name : {classTeacherName} Phone number is {classTeacherPhoneNumber}");

            }

        }


        internal void displayStudentDetails()
        {
            rollNumber = 2;
            studentName = "Rahul";
            studentCity = "Patna";
            studentPhoneNumber = 8123414418;
            studentClass = 10;
            classSection = 'A';
            registeredStudent = true;
            classTeacherName = "Mr. Ramesh";
            Console.WriteLine("Internal access specifier: are accessible within the 'project'");
            Console.WriteLine($"Roll number: {rollNumber} Student Name: {studentName} Student City : {studentCity} Phone Number : {studentPhoneNumber} Class: {studentClass} Section: {classSection} Registered Student : {registeredStudent}");

        }

        public void displaySchoolContactDetails()
        {
            Console.WriteLine("Public Access Specifier:");
            Console.WriteLine($"School Location : {schoolLocation} Schoool Contact number : {schoolPhoneNumber}");

        }


        static void Main(string[] args)
        {
            AccessSpecifiersIntroduction acc = new AccessSpecifiersIntroduction();
            acc.displaySchoolDetails();
            acc.displayStudentResult();
            acc.displayClassTeacherDetails();
            acc.displayStudentDetails();
            acc.displaySchoolContactDetails();

            Console.ReadKey();

        }



    }
}
