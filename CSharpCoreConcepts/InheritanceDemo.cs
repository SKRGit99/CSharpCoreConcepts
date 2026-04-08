using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{

    public class SchoolDetails
    {
        /*Non-Static or Instance variables*/
        
        public string motto = string.Empty;
        public string vision = string.Empty;
        public string description = string.Empty;
        public string addressLine1 = string.Empty;
        public string addressLine2 = string.Empty;
        public string city = string.Empty;
        public string state = string.Empty;
        public string country = string.Empty;
        public string zipCode = string.Empty;
        public string email = string.Empty;
        public string websiteURL = string.Empty;

        /*Static variables*/
        internal static string schooolCode = "ABCPAT88";
        protected static string affiliationBoard = "CBSE";

        /*Constant variables*/
        public const string schoolName = "ABC International School";
        const int schoolID = 1;
        protected internal const int establishedYear = 2019;

        /*ReadOnly variables*/
        protected readonly string registrationNumber = "81234ABCPAT";
        public readonly long schoolPhoneNumber = 8123414418;

        /* Without this Parameterless Constructor here in this Base Class 'SchoolDetails', It will show error in Parameterized Constructors in Child Classes: schoolDepartment,studentDetails; 
         * Errors in our child class constructors come down to inheritance rules and constructor chaining in C#.
         
         🔹 Root Cause
            Your base class SchoolDetails does not have a parameterless constructor. It only defines:
            public SchoolDetails(string addLine1, string addLine2, string city, string state, string country, string zipCode, string emailID, string schURL)
            Because of this, any derived class (schoolDepartment, studentDetails) must explicitly call the base constructor and pass the required arguments. If you don’t, the compiler tries to call a non existent default constructor (SchoolDetails()), which causes the error.

         
         */
        public SchoolDetails() { }
        public SchoolDetails(string addLine1,string addLine2, string city, string state, string country, string zipCode, string emailID, string schURL)
        {
            this.addressLine1 = addLine1;
            this.addressLine2 = addLine2;
            this.city = city;
            this.state = state;
            this.country = country;
            this.zipCode = zipCode;
            this.email = emailID;
            this.websiteURL = schURL;
        }

        void displaySchoolIDCode()
        {
            schooolCode = "ABCPAT01";
            Console.WriteLine($"School Id is: {schoolID} and School Code is: {schooolCode}");
        }

        protected void displaySchoolDetails()
        {
            Console.WriteLine($"School ID is {schoolID} School Code is {schooolCode} School Name is {schoolName} School Registration Number is {registrationNumber} School Affiliated to {affiliationBoard} Board");
        }

        public void displaySchoolContactDetails()
        {
            Console.WriteLine($"School Address is {addressLine1} {addressLine2} City {city} State {state} Country {country} Zip Code {zipCode} Email {email} School Phone Number {schoolPhoneNumber} ");


        }



    }

    public class SchoolDepartment : SchoolDetails
    {
        /*Non-Static or Instance variables*/
        int departmentId;
        protected string? departmenCode;
        public string departmentName = string.Empty;

        public SchoolDepartment() { }
        public SchoolDepartment(int deptId, string deptCode, string deptName)
        {
            this.departmentId = deptId;
            this.departmenCode = deptCode;
            this.departmentName = deptName;
             
        }
        void displayDepartmentID()
        {
            Console.WriteLine($"Department ID is {departmentId}");

        }

        protected void displayDepartmentCode()
        {
            //displaySchoolIDCode(); we can not access any private method or field outside that class.

            /*we can access 'protected' method or field into child class.*/
            
            displaySchoolDetails(); 

            affiliationBoard = "ICSE"; //Check if we can modify this Static Variable value.

            Console.WriteLine($"School Name : {schoolName} School Affiliation Board : {affiliationBoard} Department ID : {departmentId} Department code is {departmenCode}");

        }

    }

    public class StudentDetails : SchoolDepartment
    {
        /*Non-Static or Instance variables*/
        int studentId;

        protected char registeredStudent;

        public string studentName = string.Empty;

        public int rollNumber = 0;

        public string studentClass = string.Empty;

        public char classSection;

        protected internal long studentPhoneNumber;

        public string studentCity = string.Empty;

        public StudentDetails(int studentId, char regStudent, string stdName, int rollNum, string stdClass, char stdSection, long phoneNum, string stdCity)
        {
            /*Intialization and Memory allocation to Non-Static or instance variables through Constructor calling*/
            this.studentId = studentId;
            this.registeredStudent = regStudent;
            this.studentName = stdName;
            this.rollNumber = rollNum;
            this.studentClass = stdClass;
            this.classSection = stdSection;
            this.studentPhoneNumber = phoneNum;
            this.city = studentCity;
        }
        public void displayStudentDetails()
        {
            displaySchoolDetails(); // This is Protected method from Parent Class 'SchoolDetails' and we can directly call it over here.

            displayDepartmentCode(); // This is Protected method from Parent Class 'schoolDepartment' and we can directly call it over here as well.

            Console.WriteLine($"Student Id : {studentId} Registered Student [Y/N] : {registeredStudent} Student Name : {studentName} Roll Number : {rollNumber} Class : {studentClass} Section : {classSection} Phone Number : {studentPhoneNumber} City : {city}");
        }

        static void Main(string[] args)
        {
            StudentDetails stddet = new StudentDetails(1, 'Y', "Sampat", 1, "10C", 'C', 8888999910, "Patna");

            stddet.displayStudentDetails();

            stddet.displaySchoolContactDetails();

            SchoolDepartment schdept = new SchoolDepartment(1, "M01", "MATHEMATICS");

            SchoolDetails schdet = new SchoolDetails("Boring Road", "Near A N College", "Patna", "Bihar", "India", "800020", "ABC@GMAIL.COM", "ABCSCHOOL.COM");

            Console.ReadKey();
        }

    }
    

        

    
}
