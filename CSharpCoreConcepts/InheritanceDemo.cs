using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{

    /*
        The Summary of Inheritance:

        Inheritance
        ===========
        A -- > Parent Class

        B -- > Child Class

            [1] Check if there exists a relationship between the Classes or not?

            If there does exist a relationship then we can avoid creating multiple objects and instead use Child Class Object to access even the Parent Class Fields, properties and methods.

            But the vice versa will not happen i.e. We can access Child Class objects using an Object of Parent Class.
 
            Note: When A become parent and B becomes child then in almost 99% cases we will create object of B.

            [a] Fields Methods and Properties with 'public' access specifier ---> always welcome to access i.e. Not only in child classes but other classes also can access.

            [b] But 'private' access specifier ---> Never accessible outside the class i.e. Even child can not access.

            [c] Protected  (Only made for inheritance purpose) --->  Behaves like public for Child class and behaves like private for other class


            We understood what happens when we have Private Public and Protected access specifiers On Data / on function.
     
     
        [2] Types of inheritance:
        ------------------------

        [a] Simple inheritance		(Simple Inheritance means 2 generation i.e. One Parent - One Child Class.)

        [b] Hierarchical / Multi level (Hierarchical only but multiple hierarchy)

        [c] Multiple inheritance (in C++ it was introduced but later removed.)       (Not supported here in C#)
     
            A

	        B : A

	        C : B

	        --------------------


	        G


	        X: G           Y:G



	        A : X

	        B : Y
     
     
        Constructor chaining:
        ====================
        A  -->  B   ---> C			Program.cs is going to send three parameters to C Class.

  	    <------------------------------------------ Data assignment

	
	    During Constructor chaining the access/execution of constructor will be C -- > B and then B -- > A

 	    However, the data initialization/data assignment/ data accept  will be A < -- B and then B < -- C


	    Sealed Class :
	    ==============
	    Can not have a Child Class.
	    Hence, it can not be Inherited.
	
	
 	    Sealed class MyConfig
	    {
   
   		    // may be here we have some secret info which are not interested to share to any other class even by mistake

 	    }


  	    class MyOtherClass   
	    {

  	    }
     
     
     */



    public class SchoolDetails
    {
        int _schoolId;
        protected int SchooolId 
        { 
            get { return _schoolId; } 
            set { _schoolId = value; } 
        }

        string _schoolCode = string.Empty;
        protected string SchoolCode 
        { 
            get { return _schoolCode; } 
            set { _schoolCode= value; }
        }

        string _schoolName = string.Empty;
        public string SchooolName 
        { 
            get { return _schoolName; } 
            set { _schoolName = value; }
        }

        string _registrationNumber = string.Empty;
        protected string RegistrationNumber
        {
            get { return _registrationNumber; } 
            set { _registrationNumber = value; }
        }

        DateTime _establishmentYear = DateTime.MinValue;
        public DateTime EstablishmentYear
        {
            get { return _establishmentYear; }
            set { _establishmentYear = value; }
        }

        string _affiliationBoard = string.Empty;
        public String AffiliationBoard
        {
            get { return _affiliationBoard; }
            set { _affiliationBoard = value; }
        }
        
        string _motto = string.Empty;
        public string Motto
        {
            get { return _motto; }
            set { _motto = value; }
        }

        string _vision = string.Empty;
        public string Vision
        {
            get { return _vision; }
            set { _vision = value; }
        }

        string _description = string.Empty;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        string _addressLine1 = string.Empty;
        public string AddressLine1
        {
            get { return _addressLine1; }
            set { _addressLine1 = value; }
        }

        string _addressLine2 = string.Empty;
        public string AddressLine2
        {
            get { return _addressLine2; }
            set { _addressLine2 = value; }
        }

        string _fullAddress = string.Empty;
        public string FullAddress
        {
            get { return _fullAddress; }
            set { _fullAddress = value; }
        }

        string _city = string.Empty;
        public String City
        {
            get { return _city; }
            set { _city = value; }
        }

        string _state = string.Empty;
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        string _country = string.Empty;
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        string _zipCode = string.Empty;
        public String ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        string _websiteURL = string.Empty;
        public string WebsiteURL
        {
            get { return _websiteURL; }
            set { _websiteURL = value; }
        }

        long _schoolPhoneNumber;
        public long SchoolPhoneNumber
        {
            get { return _schoolPhoneNumber; }
            set { _schoolPhoneNumber = value; }
        }
       
        
        /* Without this Parameterless Constructor here in this Base Class 'SchoolDetails', It will show error in Parameterized Constructors in Child Classes: schoolDepartment,studentDetails; 
         * Errors in our child class constructors come down to inheritance rules and constructor chaining in C#.
         
         🔹 Root Cause
            Your base class SchoolDetails does not have a parameterless constructor. It only defines:
            public SchoolDetails(string addLine1, string addLine2, string city, string state, string country, string zipCode, string emailID, string schURL)
            Because of this, any derived class (schoolDepartment, studentDetails) must explicitly call the base constructor and pass the required arguments. 
            If you don’t, the compiler tries to call a non existent default constructor (SchoolDetails()), which causes the error.

         
         */
        public SchoolDetails() 
        {
            this._schoolId = 10;
            this._schoolCode = "SKRPAT01";
            this._schoolName = "SKR International School";
            this._registrationNumber = "SKRPATCBSE";
            this._establishmentYear = DateTime.Parse("2018-03-18");
            this._affiliationBoard = "CBSE";
            this._motto = "Education for everyone";
            this._vision = "Education for Bihar";
            this._description = "CBSE Affiliated School with AI Labs";
            this._addressLine1 = "Saguna More";
            this._addressLine2 = "Danapur";
            this._city = "Patna";
            this._state = "Bihar";
            this._country = "India";
            this._zipCode = "800020";
            this._email = "contact@skrschool.com";
            this._websiteURL = "www.skrschool.com";
            this._schoolPhoneNumber = 8123414488;


            Console.WriteLine($"School ID : {_schoolId} School Code : {_schoolCode} School Name : {_schoolName}");
        }
        public SchoolDetails(int schId, string schCode, string schName,string schRegNum, DateTime estYear,string affBoard, string motto, string vision, string schDesc, string addLine1, string addLine2, string city, string state, string country, string zipCode, string emailID, string schURL, long schPhoneNum)
        {
            this._schoolId = schId;
            this._schoolCode = schCode;
            this._schoolName = schName;
            this._registrationNumber = schRegNum;
            this._establishmentYear= estYear;
            this._affiliationBoard = affBoard;
            this._motto = motto;
            this._vision = vision;
            this._description=schDesc;
            this._addressLine1 = addLine1;
            this._addressLine2 = addLine2;
            this._city = city;
            this._state = state;
            this._country = country;
            this._zipCode = zipCode;
            this._email = emailID;
            this._websiteURL = schURL;
            this._schoolPhoneNumber =schPhoneNum; 

            Console.WriteLine("Constructor Chaining Concept: SchoolDetails - - > SchoolDepartment  - - > StudentDetails. SchoolDetails Class Constructor is called in the Last.");

        }

        void displaySchoolIDCode()
        {
            Console.WriteLine($"School Id is: {_schoolId} School Code is: {_schoolCode}");
        }

        protected void displaySchoolDetails()
        {
            Console.WriteLine($"School ID : {_schoolId} School Code : {_schoolCode} School Name : {_schoolName} School Registration Number : {_registrationNumber} School establishment Year : {_establishmentYear} School Affiliated Board : {_affiliationBoard} ");
        }

        public void displaySchoolContactDetails()
        {
            Console.WriteLine($"School Address is {_addressLine1} {_addressLine2} City {_city} State {_state} Country {_country} Zip Code {_zipCode} Email {_email} School Phone Number {_schoolPhoneNumber} ");


        }



    }

    public class SchoolDepartment : SchoolDetails
    {
        /*Non-Static or Instance variables*/
        int _departmentId;

        protected int DepartmentId
        {
            get { return _departmentId; } 
            set { _departmentId = value; }
        }

        string? _departmenCode;
        protected string? DepartmenCode
        {
            get { return _departmenCode; }
            set { 
                if(value==null)
                throw new ArgumentNullException("Department Code can not be null");
                _departmenCode = value; }
        }

        string _departmentName = string.Empty;
        public string? DepartmentName
        {
            get { return _departmentName; }
            set {
                if (value == null)
                    throw new ArgumentNullException("Department Name can not be null");
                    _departmentName = value;
            }
        }

        public SchoolDepartment() 
        { 
            this._departmentId = 1;
            this._departmenCode= "MAT";
            this._departmentName = "Mathematics";
        }
        public SchoolDepartment(int deptId, string deptCode, string deptName)
        {
            this._departmentId = deptId;
            this._departmenCode = deptCode;
            this._departmentName = deptName;

            Console.WriteLine("Constructor Chaining Concept: SchoolDetails - - > SchoolDepartment  - - > StudentDetails. SchoolDepartment Class Constructor is called Second.");


        }
        void displayDepartmentID()
        {
            Console.WriteLine($"Department ID is {_departmentId}");

        }

        protected void displayDepartmentCode()
        {
            //displaySchoolIDCode(); //we can not access any 'private' method or field outside the class. Since This method has 'Private' access specifier in Parent Class. Hence, it can not be directly accessed outside that class. NOT Accessible even in Child Class.

            /*we can access 'protected' methods or field into child class.*/
            
            displaySchoolDetails();   //Protected in Parent Class.
            SchooolId = 20;
            SchoolCode = "ABCPAT02";  //Protecetd fields in parent Class.

            Console.WriteLine($" School Id : {SchooolId} School Code : {SchoolCode} School Name : {SchooolName} School Affiliation Board : {AffiliationBoard} Department ID : {DepartmentId} Department code is {DepartmenCode}");

        }

    }

    public class StudentDetails : SchoolDepartment
    {
        /*Non-Static or Instance variables*/
        int _studentId;
        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        char _registeredStudent;
        protected char RegisteredStudent
        {
            get { return _registeredStudent; }
            set { _registeredStudent = value; }
        }

        string _studentName = string.Empty;
        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }

        int _rollNumber = 0;
        public int RollNumber
        {
            get { return _rollNumber; }
            set { _rollNumber = value; }
        }

        string _studentClass = string.Empty;
        public string StudentClass
        {
            get { return _studentClass; }
            set { _studentClass = value; }

        }

        char _classSection;
        public char ClassSection
        {
            get { return _classSection; }
            set { _classSection = value; }

        }

        long _studentPhoneNumber;
        public long StudentPhoneNumber
        {
            get { return _studentPhoneNumber; }
            set { _studentPhoneNumber = value; }

        }

        string _studentCity = string.Empty;
        public string StudentCity
        {
            get { return _studentCity; }
            set { _studentCity = value; }
        }


        public StudentDetails()
        {
            this._studentId = 1;
            this._registeredStudent = 'Y';
            this._studentName = "Sampat";
            this._rollNumber = 1;
            this._studentClass = "10A";
            this._classSection = 'A';
            this._studentPhoneNumber = 8123414488;
            this._studentCity = "Patna";
            
        }
        public StudentDetails(int schoolId, string schoolCode, string schoolName, string regisNumber, DateTime estYear, string afffBoard, string motto, string vision, string description, string addLine1, string addLine2, string city, string state, string country, string zipCode, string emailId, string webURL, long schPhoneNumber, int deptId, string deptCode, string deptName, int studentId, char regStudent, string stdName, int rollNum, string stdClass, char stdSection, long phoneNum, string stdCity)
        {

            /*Intialization and Memory allocation to Non-Static or instance variables through Constructor calling*/
            this._studentId = studentId;
            this._registeredStudent = regStudent;
            this._studentName = stdName;
            this._rollNumber = rollNum;
            this._studentClass = stdClass;
            this._classSection = stdSection;
            this._studentPhoneNumber = phoneNum;
            this._studentCity = stdCity;

            Console.WriteLine("Constructor Chaining Concept: Constructor call will begin with Last Inherited or Child Class Constructor method. SchoolDetails - - > SchoolDepartment  - - > StudentDetails. So, StudentDetails Class Constructor is called First.");
        }
        public void displayStudentDetails()
        {
            displaySchoolDetails(); // This is Protected method from Parent Class 'SchoolDetails' and we can directly call it over here.

            displayDepartmentCode(); // This is Protected method from Parent Class 'schoolDepartment' and we can directly call it over here as well.

            displaySchoolContactDetails();

            //In the below line, we are directly accessing Protected fields from Parent Classes. E.g. SchoolId and SchoolCode are Preotected fields.

            Console.WriteLine($"School ID : {SchooolId} School Code : {SchoolCode} School Nmae : {SchooolName} Department : {DepartmentName} Student Id : {_studentId} Registered Student [Y/N] : {_registeredStudent} Student Name : {_studentName} Roll Number : {_rollNumber} Class : {_studentClass} Section : {_classSection} Phone Number : {_studentPhoneNumber} City : {_studentCity}");
        }

        
        static void Main(string[] args)
        {

            StudentDetails stddetail = new StudentDetails();
            stddetail.displayStudentDetails();

            stddetail.displayDepartmentCode();
            stddetail.displaySchoolDetails();
            stddetail.displaySchoolContactDetails();

            StudentDetails stddet = new StudentDetails(20,"SKRPAT02","SKR International School Patna","SKRPATICSE", DateTime.Parse("2018-04-18"), "CBSE","Education for All","Education for India","ICSE Affiliated School with AI Labs","Vitthal VR Complex","Saguna More Danapur","Patna","Bihar","India","800040","info@skrschool.com","www.skrschool.org",8123414499,2,"PHY","Physics", 2, 'Y', "Anupam", 2, "10B", 'B', 8123414490, "Khagaria");
            stddet.displayStudentDetails();
            stddet.displayDepartmentCode();
            stddet.displaySchoolDetails();
            stddet.displaySchoolContactDetails();

           
            Console.ReadKey();
        }

    }
    

        

    
}
