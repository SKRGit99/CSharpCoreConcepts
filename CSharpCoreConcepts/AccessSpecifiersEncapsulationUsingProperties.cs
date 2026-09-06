using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class AccessSpecifiersEncapsulationUsingProperties
    {
        /*      Modifiers : All the 'keywords' are generally known as 'Modifiers'. e.g.Static,
                                                                                    Public,
                                                                                    Private,
                                                                                    Virtual,
                                                                                    Override,
                                                                                    Abstract etc.

                Access Specifiers : These are special kind of 'Modifiers' with the help of which we can define the 'Scope' of a 'Type' and its 'Members'.

                Type and its Members : Type is Class and it's fields are its Members.

                Scope : It simply means accessibility or visibility. i.e. Who can consume and Who can not.

                C# supports Five types of Access Specifiers:
                ===========================================

                Private :   Accessible only within the Class in which it is defined.
                            But we can access them in another Classes through Implementation in Methods.

                            e.g. Fields such as _schoolID, _schooolCode, _registrationNumber are all Private fields.

                            So, we will not be able to access them directly outside this Class but we can access them through 
                            their Implementation in Methods or through Properties.

                            By default the scope of Every "member" in a Class is Private.
                            
                            Very Important: 
                            ==============
                            We can not declare Private on "types".
                            e.g. We can not declare 'Class' as 'Private'.

                Protected : These fields are accessible Only In Child Class and not in Non-Child Classes 
                            i.e. Without Inheritance Not accessible Outside the Class.

                            Example: Properties 'SchoolID', 'SchoolCode', 'RegistrationNumber' are Protected.
                            Hence they would be accessible only in Inherited Child Classes.
                            
                            MoreOver , Classes can not be declared Protected as we have seen earlier.

                [Qn] Can we declare Private on Classes?
                [Ans] No. we can not declare Private on Types like Classes.

                [Qn] Can we declare Protected on Classes?
                [Ans] No. we can not declare Protected on Classes.

                Internal :  Accessible only within the same assembly (project).
                            A member declared Internal is accessible only within the Project i.e. In Child Class as well as Non Child Class.
                            It shall not be accessible from Outside the Project.
                            
                            Example:  Property 'IsSchoolRegistered' is Internal.

                Protected - Internal:   Accessible within the same assembly and in derived classes(outside that Assembly) as well.
                                        Any class inside the assembly can access but also sub-classes 'outside' the assembly can still access too.
                                        so, it offers more flexibility than Internal.


                Public: If a Type is declared as "public" ,It simply means accessible from anywhere.


                Summary:
                =======
                Private >>>> Protected >>> Internal >> Protected Internal > Public

        
                Implementation of Properties
                ============================

                Best Practice
                •	Fields → keep them private (sometimes protected if inheritance needs it).
                •	Properties → make them public (or internal/protected internal if you want limited exposure).
                •	Public fields → avoid them. If you need external access, use properties instead.


                * Properties give you control and flexibility compared to plain fields:

                [a] Encapsulation → You can hide internal details and expose only what’s needed.

                The field _schoolID is private → hidden from outside code.

                The property SchoolID is Protected → controlled access point.

                You decide what rules apply when someone tries to read or write it.

                [b] Validation → You can add logic in set (e.g., prevent negative experience).

                [c] Consistency → They look like fields when used, but behave like methods.
                
                Summary:
                =======
                Here we will implemnt the best practices in C# i.e. 
                [a] keep all the fields as 'Private' and 
                [b] Keep Properties as Protected, Internal, Protected Internal or Public.
                e.g. Private Access Specifier: _schoolID and _schooolCode : Since No Access Specifier is explicitly defined so by default is will be "Private".

    

                Encapuslation using Properties:
                ==============================
                Properties are most useful when the actual data is stored in a 'private' field. 
                The property then acts as the 'public interface' to that 'private data'.
       
                Properties are not only for private fields, but they are primarily designed to wrap 'private' fields. 
                That’s how they enforce 'encapsulation'. 
        
                Public fields bypass this mechanism, which is why in real-world C# development, we almost always see properties instead of public fields

                Class : We know a Class is a Logical unit or Blueprint that contains:
                [a] Fields.
                [b] Properties 
                [c] Methods.


        */

        /*School Details*/

                static int _schoolID = 20;  // _schoolID is a Field. Declared this as Static Varriable since it's value would be almost constant.
                protected int SchoolID     // SchoolID is Property. SchoolID should not be publicly accessible. It should be inherited only in the Child Classes.
                {
                    get { return _schoolID; }
                    set
                    {
                            if (value < 10)             // Implementation of Validation
                            
                            throw new ArgumentException("School ID can not be less than 10.");
                            _schoolID = value;
                    }
                }

                static string _schooolCode = "ABCPAT01";
                protected string SchooolCode
                {
                    get { return _schooolCode; }
                    set
                    {
                        if (value == null)
                            throw new ArgumentNullException("School Code can not be null.");
                            _schooolCode = value;
                    }
                }

                static string _registrationNumber = "ABC8888";
                protected string RegistrationNumber
                {
                    get { return _registrationNumber; }
                    set
                    {
                         _registrationNumber = value;
                    }
                }

                char _isSchoolRegistered;
                internal char IsSchoolRegistered        // IsSchoolRegistered should not be publlicly accessible. It should be accessible onlly inside the project.
                {   get { return _isSchoolRegistered; }
                    set {
                            if ((value !='Y') && (value !='N'))
                            throw new ArgumentException("Invalid Value. Please Enter Y/N.");
                            _isSchoolRegistered = value; }
                }

                DateOnly _establishedYear;
                protected DateOnly EstablishedYear
                {   
                    get { return _establishedYear; }
                    set {
                             _establishedYear = value; 
                        }
        
            
                }

                string _schoolName = string.Empty;
                public string SchoolName
                {
                    get { return _schoolName; }
                    set
                    {
                        if (value == null)
                            throw new ArgumentNullException("SchoolName can not be null.");
                            _schoolName = value;
                    }
                }

                string _affiliationBoard = string.Empty;
                public string AffiliationBoard
                {
                    get { return _affiliationBoard; }
                    set {
                            if (value == null)
                            throw new ArgumentNullException("Affiliation Board can not be null.");

                            _affiliationBoard = value; }
                }

                long _schoolPhoneNumber;
                public long SchoolPhoneNumber
                {

                    get { return _schoolPhoneNumber; }
                    set { 
                            if((value <0) || (value.ToString().Length < 10))
                            throw new ArgumentException("Phone Number can not be less than 10 digits and less than 0.");
                            _schoolPhoneNumber = value; 
                        }
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
                    set {
                            if (value == null)
                            throw new ArgumentNullException("AddressLine1 can not be null.");
                            _addressLine1 = value; 
                        }
                }

                string _addressLine2 = string.Empty;
                public string AddressLine2
                {
                    get { return _addressLine2; }
                    set { _addressLine2 = value; }
                }

                string _city = string.Empty;
                public string City
                {
                    get { return _city; }
                    set {
                            if (value == null)
                            throw new ArgumentNullException("City can not be null.");
                            _city = value; 
                        }
                }

                string _state = string.Empty;
                public string State
                {
                    get { return _state; }
                    set {
                            if (value == null)
                            throw new ArgumentNullException("State can not be null.");
                            _state = value; 
                        }
                }

                string _country = string.Empty;
                public string Country
                {
                    get { return _country; }
                    set {
                            if (value == null)
                            throw new ArgumentNullException("Country can not be null.");
                            _country = value; 
                        }
                }

                string _zipCode = string.Empty;
                public string ZipCode
                {
                    get { return _zipCode; }
                    set { _zipCode = value; }
                }

                string _email = string.Empty;
                public string Email
                {
                    get { return _email; }
                    set {
                            if (value == null)
                            throw new ArgumentNullException("Email can not be null.");
                            _email = value; 
            
                        }
                }

                string _websiteURL = string.Empty;
                public string WebsiteURL
                {
                    get { return _websiteURL; }
                    set {
                            if (value == null)
                            throw new ArgumentNullException("WebsiteURL can not be null.");
                            _websiteURL = value; 
                        }
                }


    /*StudentDetails*/

                string _studentFirstName =string.Empty;
                public string StudentFirstName 
                {   get { return _studentFirstName; } 
                    set 
                    {
                        if (value == null)
                        throw new ArgumentNullException("Student Fisrt Name can not be null.");
                        _studentFirstName = value; 
                    } 
                }


                string _studentMiddleName = string.Empty;
                public string StudentMiddleName
                {
                    get { return _studentMiddleName; }
                    set
                    {
                         _studentMiddleName = value;
                    }
                }

                string _studentLastName = string.Empty;
                public string StudentLastName
                {
                    get { return _studentLastName; }
                    set
                    {
                         _studentLastName = value;
                    }
                }

                string _studentFullName = string.Empty;
                public string StudentFullName
                {
                    get { return _studentFullName; }
                    set
                    {
                        _studentFullName = value;
                    }
                }

                int _studentID;
                internal int StudentID
                {
                    get { return _studentID; }
                    set
                    {
                        if (value < 0)
                            throw new ArgumentOutOfRangeException("StudentID can not be less than 0.");
                        _studentID = value;
                    }
                }

                char _registeredStudent;

                internal char IsRegisteredStudent
                {
                    get { return _registeredStudent; }

                    set {
                            if ((value != 'Y') && (value != 'N'))
                                throw new ArgumentException("Invalid Value. Please Select Y/N.");
                                _registeredStudent = value; 
                        }
                }

                DateTime _studentRegistrationDate;
                protected DateTime StudentRegistrationDate
                {
                    get { return (DateTime)_studentRegistrationDate; }
                    set { _studentRegistrationDate = value; }
                }
                

                int _rollNumber;
                public int RollNumber
                {
                    get { return _rollNumber; }
                    set
                    {
                        if (value < 0)
                            throw new ArgumentException("Roll number can not be lessa than 0.");
                        _rollNumber = value;
                    }
                }
                

                string _StudentClass = string.Empty;
                public string StudentClass
                {
                    get { return _StudentClass; }
                    set
                    {
                        if (value == null)
                        throw new ArgumentNullException("Student Class can not be empty.");
                        _StudentClass = value;
                    }
                }
                
                char _studentSection;
                public char Section
                {
                    get { return _studentSection; }
                    set { _studentSection = value; }
                }

                long _studentPhoneNumber;
                protected long StudentPhoneNumber
                {
                    get { return _studentPhoneNumber; }
                    set {
                            if (value <0)
                            throw new ArgumentException("Student Phone number can not be less than 0");
                            _studentPhoneNumber = value; 
            
                        }
                }


                string _StudentaddressLine1 = string.Empty;
                protected string StudentaddressLine1
                {
                    get { return _StudentaddressLine1; }
                    set
                    {
                        if (value == null)
                            throw new ArgumentNullException("AddressLine1 can not be null.");
                        _StudentaddressLine1 = value;
                    }
                }

                string _studentAddressLine2 = string.Empty;
                protected string StudentAddressLine2
                {
                    get { return _studentAddressLine2; }
                    set { _studentAddressLine2 = value; }
                }

                string _studentFullAddress = string.Empty;
                protected string StudentFullAddress
                {
                    get { return _studentFullAddress; }
                    set { _studentFullAddress = value; }
                }

                string _studentCity = string.Empty;
                protected string StudentCity
                {
                    get { return _studentCity; }
                    set
                    {
                        if (value == null)
                            throw new ArgumentNullException("City can not be null.");
                        _studentCity = value;
                    }
                }

                string _studentState = string.Empty;
                protected string StudentState
                {
                    get { return _studentState; }
                    set
                    {
                        if (value == null)
                            throw new ArgumentNullException("State can not be null.");
                        _studentState = value;
                    }
                }

                string _studentCountry = string.Empty;
                protected string StudentCountry
                {
                    get { return _studentCountry; }
                    set
                    {
                        if (value == null)
                            throw new ArgumentNullException("Country can not be null.");
                        _studentCountry = value;
                    }
                }

                string _studentZipCode = string.Empty;
                protected string StudentZipCode
                {
                    get { return _studentZipCode; }
                    set { _studentZipCode = value; }
                }

                string _studentEmailID = string.Empty;
                protected string StudentEmailID
                {
                    get { return _studentEmailID; }
                    set
                    {
                        if (value == null)
                            throw new ArgumentNullException("Student EmailID can not be null");
                        _studentEmailID = value;
                    }
                }

                  
            
    /*Faculty details*/
                
                int _FacultyID;
                internal int FacultyID
                {
                    get { return _FacultyID; }
                    set {
                            if (value < 0)
                            throw new ArgumentException("Faculty ID can not be less than 0.");
                            _FacultyID = value;
                        }
                }

                string _FacultyFirstName = string.Empty;
                internal string FacultyFirstName
                {
                    get { return _FacultyFirstName; }
                    set {
                            if (value == null)
                            throw new ArgumentNullException("Faculty Name can not be null");
                            _FacultyFirstName = value;
            
            
                        }
                }

                string _FacultyMiddleName = string.Empty;
                internal string FacultyMiddleName
                {
                    get { return _FacultyMiddleName; }
                    set
                    {
                       _FacultyMiddleName = value;
                    }


                }


                string _FacultyLastName = string.Empty;
                internal string FacultyLastName
                {
                    get { return _FacultyLastName; }
                    set
                    {
                        _FacultyLastName = value;

                    }


                }

                string _FacultyFullName = string.Empty;
                internal string FacultyFullName
                {
                    get { return _FacultyFullName; }
                    set
                    {
                        _FacultyFullName = value;

                    }
                }

                int _FacultyDepartmentID;
                internal int FacultyDepartmentID
                {
                    get { return _FacultyDepartmentID; }
                    set { 
                            if (value < 0)
                            throw new ArgumentException("Faculty Department ID can ot be less than Zero");
                            _FacultyDepartmentID = value;
                        
                        
                        }
                }

                string _FacultySubject=string.Empty;
                internal string FacultySubject
                {
                    get { return _FacultySubject; }
                    set
                    {
                        if (value == null)
                            throw new ArgumentNullException("Subject can not be null");
                        _FacultySubject = value;
                    }
                }


                char _isFacultyOnPermanentPayroll;
                protected char IsFacultyOnPermanentPayroll
                {
                    get { return _isFacultyOnPermanentPayroll; }
                    set { _isFacultyOnPermanentPayroll = value; }
                }

                int _FacultyPayScale;
                protected int FacultyPayScale
                {
                    get { return _FacultyPayScale; }
                    set
                    {
                        if (value < 0)
                            throw new ArgumentException("PayScale can not be less than 0.");
                        _FacultyPayScale = value;
                    }
                }





     /*Exam Details*/
                int _examId;
                internal int ExamID
                { 
                    get { return _examId; }
                
                    set { if (value < 0)
                    throw new ArgumentException("Exam Id can not be less than 0."); 
                    _examId = value;}
                }
                
                string _examCode = string.Empty; 
                protected string ExamCode
                {
                    get { return  _examCode; }
                    set {_examCode = value; }
                }

                string _examName = string.Empty;
                protected string ExamName
                {
                    get { return _examName; }
                    set { _examName = value; }
                }

                string _examYear=string.Empty;
                public string ExamYear
                {
                    get { return _examYear; }
                    set { _examYear = value; }
                }

                int _mathsMarks;
                protected int MathsMarks
                {
                    get { return _mathsMarks; }
                    set {
                            if (value < 0)
                            throw new ArgumentException("Marks can  not be less than 0");
                            _mathsMarks = value; 
                        }
                }

                int _scienceMarks;
                protected int ScienceMarks
                {
                    get { return _scienceMarks; }
                    set
                    {
                        if (value < 0)
                            throw new ArgumentException("Marks can  not be less than 0");
                        _scienceMarks = value;
                    }
                }


                int _englishMarks;
                protected int EnglishMarks
                {
                    get { return _englishMarks; }
                    set
                    {
                        if (value < 0)
                            throw new ArgumentException("Marks can  not be less than 0");
                            _englishMarks = value;
                    }
                }

                int _hindiMarks;
                protected int HindiMarks
                {
                    get { return _hindiMarks; }
                    set
                    {
                        if (value < 0)
                            throw new ArgumentException("Marks can  not be less than 0");
                        _hindiMarks = value;
                    }
                }
                
                int _socialScienceMarks;
                protected int SocialScienceMarks
                {
                    get { return _socialScienceMarks; }
                    set
                    {
                        if (value < 0)
                            throw new ArgumentException("Marks can  not be less than 0");
                        _socialScienceMarks = value;
                    }
                }

                int _totalMarks;
                public int TotalMarks
                {
                    get { return _totalMarks; }
                    set
                    {
                        if (value < 0)
                            throw new ArgumentException("Marks can  not be less than 0");
                        _totalMarks = value;
                    }
                }

                public string _examResult = string.Empty;
                public string ExamResult
                {
                    get { return _examResult; }
                    set
                    {
                        if (value == null)
                            throw new ArgumentNullException("Exam result can not be null.");
                        _examResult = value;
                    }
                }
                
                
    //Private method: Can be called from Child classes as well.
                void accessPrivateMethodsOfParentClassInChildClass()
                {
                    

                    Console.WriteLine($"School Id : {_schoolID} and School Code is: {_schooolCode} ");
                    _schoolID = 30;     //We can modify the Static variables later also i.e. after the execution of the Class starts. E.g._schoolID and _schooolCode.
                    _schooolCode = "ABCPAT02";
                    Console.WriteLine($" Modified value for Static Variables School Id : {_schoolID} and School Code is: {_schooolCode} ");

                }


    //Protected method: Can be called from Child classes as well.
                protected void acccessProtecetdMethodsOfParentClassInChildClass()
                {
            
                    Console.WriteLine($"Enter your Roll number");
                    RollNumber = Convert.ToInt32(Console.ReadLine());
                    if (RollNumber == 1)
                    {
                        StudentFirstName = "Sampat";
                        StudentLastName = "Rahul";
                        MathsMarks = 75;
                        ScienceMarks = 88;
                        EnglishMarks = 78;
                        HindiMarks = 67;
                        SocialScienceMarks = 83;
                        TotalMarks = MathsMarks + ScienceMarks + EnglishMarks + HindiMarks + SocialScienceMarks;
                        Console.WriteLine($"Total marks obtained by {StudentFirstName} {StudentMiddleName} {StudentLastName} is {TotalMarks}");
                    }
                    else if (RollNumber == 2)
                    {
                        StudentFirstName = "Anupam";
                        StudentLastName = "Kumari";
                        MathsMarks = 80;
                        ScienceMarks = 88;
                        EnglishMarks = 70;
                        HindiMarks = 90;
                        SocialScienceMarks = 84;
                        TotalMarks = MathsMarks + EnglishMarks + HindiMarks + ScienceMarks + SocialScienceMarks;
                        Console.WriteLine($"Total marks obtained by {StudentFirstName} {StudentMiddleName} {StudentLastName} is {TotalMarks}");
                    }
                    else
                    {
                    Console.WriteLine($"Please enter a Valid Roll number");
                    }

            
                }

    //Internal method: Can be accessed from any class in the Project assembly.
                internal void acccessInternalMethodsOfParentClassInChildClass()
                {
                    Console.WriteLine($"Enter your Roll number");
                    RollNumber = Convert.ToInt32(Console.ReadLine());
                    if (RollNumber == 1)
                    {
                            StudentFirstName = "Sampat";
                            StudentMiddleName = "Kumar";
                            StudentLastName = "Rahul";
                            StudentClass = "10E";
                            Section = 'E';
                            City = "Patna";
                            StudentPhoneNumber = 8123414418;
                            IsRegisteredStudent = 'Y';
                            Console.WriteLine($"Roll number : {RollNumber} Student Name: {StudentFirstName} {StudentMiddleName} {StudentLastName} Student City : {City} Phone Number : {StudentPhoneNumber} Class: {StudentClass} Section: {Section} Registered Student : {IsRegisteredStudent}");
                    }
                    else if (_rollNumber == 2)
                    {
                            StudentFirstName = "Anupam";
                            StudentMiddleName = "";
                            StudentLastName = "Kumari";
                            StudentClass = "9E";
                            Section = 'E';
                            City = "Patna";
                            StudentPhoneNumber = 8123414418;

                            Console.WriteLine($"Roll number : {RollNumber} Student Name : {StudentFirstName} {StudentMiddleName} {StudentLastName} Student City : {City} Phone Number : {StudentPhoneNumber} Class : {StudentClass} Section : {Section} Registered Student : {IsRegisteredStudent}");
                    }


                }


               
                public void acccessPrivateFieldsOfParentClassInChildClass()
                {
                            _schoolID = 40;
                            _schooolCode = "ABCPAT03";
                            _isSchoolRegistered = 'Y';
                            _schoolName = "ABC School";
                            _establishedYear = DateOnly.FromDateTime( new DateTime(2020,1,1));
                            _addressLine1 = "Patna";
                            _addressLine2 = "Danapur, Bihar";
                            _schoolPhoneNumber = 9999999999;
            
                            Console.WriteLine("We can use this method to display Private fields like _schoolID and _schooolCode");
                            Console.WriteLine($" School ID: {_schoolID} School Code : {_schooolCode} School Name : {_schoolName} Establishment Year : {_establishedYear} Address : {_addressLine1} {_addressLine2} Contact details : {_schoolPhoneNumber} Registered School : {_isSchoolRegistered}");
                }

       


                static void Main(string[] args)
                {
                    AccessSpecifiersEncapsulationUsingProperties acc = new AccessSpecifiersEncapsulationUsingProperties();

                    acc.accessPrivateMethodsOfParentClassInChildClass();

                    acc.acccessProtecetdMethodsOfParentClassInChildClass();

                    acc.acccessInternalMethodsOfParentClassInChildClass();

                    acc.acccessPrivateFieldsOfParentClassInChildClass();

                    Console.ReadKey();

                }



    }
}
