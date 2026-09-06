using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
        public class PolyMorphismDemo
        {
        /*
                Polymorphism
                ============
                Many Forms


                Polymorphism :
                =============
                It is a solution to naming conflict when a functionality used in many forms with same name.

                Signature diff :
                ===============

                -- Number of parameter
                -- Data type of parameter
                -- Sequence of data type

                overloading :
                ============
                In a single class many forms with same name.
                Also, known as Compilation time polymorphism or Static polymorphism.


                overriding :
                ===========
                In a multiple class (inherited one another) many forms with same name.
                Alos, known as Runtime polymorphism or Dynamic polymosphism.

                Remember the example of 3 Cats and 3 Holes. Vs 3 Cats and 1 Hole.
                ================================================================
                Einstein said for 3 Cats make 3 holes.

                But it could have been done through 1 Hole also.

                Hence, Overriding helps us to call the function of Child Classes through "Single" object of the "Parent" Class.


                A -- f1(int x)


                B : A

                f1(int x);

                Can single object solve this problem scenario?
                =============================================

                -- Use "virtual" in top most parent class function where there is no conflict.
                -- Use "override" in all bottom children functions where there is conflict.
                -- While creating object to call functions : Keep a single reference of top most parent class i.e. Virtual class, and time to time instantiate that class whose memory allocation is required.


                Conclusion:
                ==========
                Top most parent class "reference" can easily hold only of child class "instance" to allocate that class memory.


         */
    }

        public class OrganizationDetails
        {
            int _schoolId;
            public int SchoolId
            {
                get { return _schoolId; }
                set { _schoolId = value; }
            }

            string _schoolCode = string.Empty;
            public string SchoolCode
            {
                get { return _schoolCode; }
                set { _schoolCode = value; }
            }

            string _schoolName = string.Empty;
            public string SchoolName
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

            string? _motto;
            public string Motto
            {
                get { return _motto ?? string.Empty; }
                set { _motto = value; }
            }

            string? _vision;
            public string Vision
            {
                get { return _vision ?? string.Empty; }
                set { _vision = value; }
            }

            string? _description;
            public string Description
            {
                get { return _description ?? string.Empty; }
                set { _description = value; }
            }

            string _addressLine1 = string.Empty;
            protected string AddressLine1
            {
                get { return _addressLine1; }
                set { _addressLine1 = value; }
            }

            string? _addressLine2;
            protected string AddressLine2
            {
                get { return _addressLine2 ?? string.Empty; }
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

            string _schoolPhoneNumber = string.Empty;
            public string SchoolPhoneNumber
            {
                get { return _schoolPhoneNumber; }
                set { _schoolPhoneNumber = value; }
            }


            public OrganizationDetails()
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
                this._fullAddress = _addressLine1 + _addressLine2;
                this._city = "Patna";
                this._state = "Bihar";
                this._country = "India";
                this._zipCode = "800020";
                this._email = "contact@skrschool.com";
                this._websiteURL = "www.skrschool.com";
                this._schoolPhoneNumber = "8123414488";

                //Console.WriteLine($"School ID : {_schoolId} School Code : {_schoolCode} School Name : {_schoolName} Registration Number : {_registrationNumber} Establishment Year : {_establishmentYear} Affiliation Board : {_affiliationBoard} Motto : {_motto} Vision : {_vision} Description : {_description} AddressLine1 : {_addressLine1} AddressLine2 : {_addressLine2} Full Address : {_fullAddress} City : {_city} State : {_state} Country : {_country} ZipCode : {_zipCode} EmailId : {_email} Website URL : {_websiteURL} Phone Number : {_schoolPhoneNumber}");
            }
            public OrganizationDetails(int schId, string schCode, string schName, string schRegNum, DateTime estYear, string affBoard, string motto, string vision, string schDesc, string addLine1, string addLine2, string city, string state, string country, string zipCode, string emailID, string schURL, string schPhoneNum)
            {
                this._schoolId = schId;
                this._schoolCode = schCode;
                this._schoolName = schName;
                this._registrationNumber = schRegNum;
                this._establishmentYear = estYear;
                this._affiliationBoard = affBoard;
                this._motto = motto;
                this._vision = vision;
                this._description = schDesc;
                this._addressLine1 = addLine1;
                this._addressLine2 = addLine2;
                this._city = city;
                this._state = state;
                this._country = country;
                this._zipCode = zipCode;
                this._email = emailID;
                this._websiteURL = schURL;
                this._schoolPhoneNumber = schPhoneNum;

                //Console.WriteLine($"School ID : {_schoolId} School Code : {_schoolCode} School Name : {_schoolName} Registration Number : {_registrationNumber} Establishment Year : {_establishmentYear} Affiliation Board : {_affiliationBoard} Motto : {_motto} Vision : {_vision} Description : {_description} AddressLine1 : {_addressLine1} AddressLine2 : {_addressLine2} Full Address : {_fullAddress} City : {_city} State : {_state} Country : {_country} ZipCode : {_zipCode} EmailId : {_email} Website URL : {_websiteURL} Phone Number : {_schoolPhoneNumber}");

            }

            //Use "virtual" in top most parent class function where there is no conflict
            public virtual void displayOrganizationDetails()
            {
                Console.WriteLine($"Organization details: School ID : {_schoolId} School Code : {_schoolCode} School Name : {_schoolName} Registration Number : {_registrationNumber} Establishment Year : {_establishmentYear} Affiliation Board : {_affiliationBoard} Motto : {_motto} Vision : {_vision} Description : {_description} AddressLine1 : {_addressLine1} AddressLine2 : {_addressLine2} Full Address : {_fullAddress} City : {_city} State : {_state} Country : {_country} ZipCode : {_zipCode} EmailId : {_email} Website URL : {_websiteURL} Phone Number : {_schoolPhoneNumber}");
            }

            public virtual void displayAddress()
            {
                Console.WriteLine($"Org. Address : {_fullAddress} City : {_city} State : {_state} Country : {_country} Zip Code : {_zipCode} Email : {_email} Phone Number : {_schoolPhoneNumber} ");
            }

            public virtual void displayCountry()
            {
                Console.WriteLine("Country: India");
            }

        }

        public class DepartmentDetails : OrganizationDetails
        {
            
            int _departmentId;

            public int DepartmentId
            {
                get { return _departmentId; }
                set { _departmentId = value; }
            }

            string _departmentCode = string.Empty;
            protected string? DepartmentCode
            {
                get { return _departmentCode; }
                set
                {
                    if (value == null)
                        throw new ArgumentNullException("Department Code can not be null");
                    _departmentCode = value;
                }
            }

            string _departmentName = string.Empty;
            public string? DepartmentName
            {
                get { return _departmentName; }
                set
                {
                    if (value == null)
                        throw new ArgumentNullException("Department Name can not be null");
                    _departmentName = value;
                }
            }

            public DepartmentDetails()
            {
                this._departmentId = 1;
                this._departmentCode = "MAT";
                this._departmentName = "Mathematics";

                //Console.WriteLine($"Parameterless Constructor called. This will assign default values to fields.");

                //Console.WriteLine($"Default values are Department Id: {_departmentId} Department Code : {_departmentCode} Department Name : {_departmentName}");
            }
            public DepartmentDetails(int deptId, string deptCode, string deptName, int schId, string schCode, string schName, string schRegNum, DateTime estYear, string affBoard, string motto, string vision, string schDesc, string addLine1, string addLine2, string city, string state, string country, string zipCode, string emailID, string schURL, string schPhoneNum) : base(schId, schCode, schName, schRegNum, estYear, affBoard, motto, vision, schDesc, addLine1, addLine2, city, state, country, zipCode, emailID, schURL, schPhoneNum)
            {
                this._departmentId = deptId;
                this._departmentCode = deptCode;
                this._departmentName = deptName;

                
                //Console.WriteLine($"Department Id: {_departmentId} Department Code : {_departmentCode} Department Name : {_departmentName}");

            }

        /*  These Child classes ought to have same access specifier for the overridden Method in the Child Classes.
         *  Use "override" in all bottom children functions where there is conflict.
         */
            public override void displayOrganizationDetails()
            {
                    Console.WriteLine($"Department Organization details: School ID : {SchoolId} School Code : {SchoolCode} School Name : {SchoolName} Registration Number : {RegistrationNumber} Establishment Year : {EstablishmentYear} Affiliation Board : {AffiliationBoard} Motto : {Motto} Vision : {Vision} Description : {Description} AddressLine1 : {AddressLine1} AddressLine2 : {AddressLine2} Full Address : {FullAddress} City : {City} State : {State} Country : {Country} ZipCode : {ZipCode} EmailId : {Email} Website URL : {WebsiteURL} Phone Number : {SchoolPhoneNumber}");

            }
            
            public override void displayAddress()
            {
                Console.WriteLine($"Department Org. Address: {FullAddress} City : {City} State : {State} Country : {Country} Zip Code : {ZipCode} Email : {Email} Phone Number : {SchoolPhoneNumber}");
            }


        }

        public class EmployeeDetails : DepartmentDetails
        {


            int _employeeId;
            public int EmployeeId
            {
                get { return _employeeId; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("EmployeeId Id can not be less than 0.");
                    _employeeId = value;
                }
            }

            string _employeeFirstName = string.Empty;
            public string EmployeeFirstName
            {
                get { return _employeeFirstName; }
                set
                {
                    if (value == null)
                        throw new ArgumentNullException("Employee First Name can not be null");
                    _employeeFirstName = value;


                }
            }

            string? _employeeMiddleName;
            public string EmployeeMiddleName
            {
                get { return _employeeMiddleName?? string.Empty; }
                set
                {
                    _employeeMiddleName = value;
                }


            }


            string? _employeeLastName;
            public string EmployeeLastName
            {
                get { return _employeeLastName ?? string.Empty; }
                set
                {
                    _employeeLastName = value;

                }


            }

            string _employeeFullName = string.Empty;
            public string EmployeeFullName
            {
                get { return _employeeFullName; }
                set
                {
                    _employeeFullName = value;
                }
            }

            DateTime _employeeDateOfBirth;
            public DateTime EmployeeDateOfBirth
            {
                get { return (DateTime)_employeeDateOfBirth; }
                set { _employeeDateOfBirth = value; }
            }

            String _employeeGender=string.Empty;
            public String EmployeeGender
            {
                get { return _employeeGender; }
                set { _employeeGender = value; }
            }

            int _employeeDepartmentId;
            protected int EmployeeDepartmentId
            {
                get { return _employeeDepartmentId; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Educator Department Id can ot be less than Zero");
                    _employeeDepartmentId = value;


                }
            }

            
            string _employeeDesignation = string.Empty;
            public string EmployeeDesignation
            {
                get { return _employeeDesignation ?? string.Empty; }
                set { _employeeDesignation = value; }
            }


            DateTime _dateOfJoining;
            public DateTime DateOfJoining
            {
                get { return _dateOfJoining; }
                set { _dateOfJoining = value; }
            }

            string _employeementType = string.Empty;
            public string EmployeementType
            {
                get { return _employeementType; }
                set { _employeementType = value; }
            }


            int _employeeManagerId;
            public int EmployeeManagerId
            {
                get { return _employeeManagerId; }
                set { _employeeManagerId = value; }
            }


            char _isEmployeeOnPermanentPayroll;
            public char IsEmployeeOnPermanentPayroll
            {
                get { return _isEmployeeOnPermanentPayroll; }
                set { _isEmployeeOnPermanentPayroll = value; }
            }

            int _employeePayScale;
            public int EmployeePayScale
            {
                get { return _employeePayScale; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("PayScale can not be less than 0.");
                        _employeePayScale = value;
                }
            }

            decimal _employeeBaseSalary;
            protected decimal EmployeeBaseSalary
            {
                get { return (decimal)_employeeBaseSalary; }
                set { _employeeBaseSalary = value; }
            }

            string _employeeQualifications=string.Empty;
            protected string EmployeeQualifications
            {
                get { return _employeeQualifications; }
                set { _employeeQualifications = value; }
            }

            int _experienceOfWork;
            public int ExperienceOfWork
            {
                get { return _experienceOfWork;}
                set { _experienceOfWork = value; }
            }

            string? _employeePhoneNumber;
            public string EmployeePhoneNumber
            {
                get { return _employeePhoneNumber ?? string.Empty; }
                set
                {
                    _employeePhoneNumber = value;

                }
            }


            string _employeeAddressLine1 = string.Empty;
            protected string EmployeeAddressLine1
            {
                get { return _employeeAddressLine1; }
                set
                {
                    if (value == null)
                        throw new ArgumentNullException("AddressLine1 can not be null.");
                _employeeAddressLine1 = value;
                }
            }

            string? _employeeAddressLine2;
            protected string EmployeeAddressLine2
            {
                get { return _employeeAddressLine2 ?? string.Empty; }
                set { _employeeAddressLine2 = value; }
            }

            string _employeeFullAddress = string.Empty;
            public string EmployeeFullAddress
            {
                get { return _employeeFullAddress; }
                set
                {
                    _employeeFullAddress = value;
                }
            }

            string _employeeCity = string.Empty;
            public string EmployeeCity
            {
                get { return _employeeCity; }
                set
                {
                    if (value == null)
                        throw new ArgumentNullException("City can not be null.");
                    _employeeCity = value;
                }
            }

            string? _employeeState;
            public string EmployeeState
            {
                get { return _employeeState ?? string.Empty; }
                set
                {
                     _employeeState = value;
                }
            }

            string? _employeeCountry;
            public string EmployeeCountry
            {
                get { return _employeeCountry ?? string.Empty; }
                set
                {
                   _employeeCountry = value;
                }
            }

            string _employeeZipCode = string.Empty;
            protected string EmployeeZipCode
            {
                get { return _employeeZipCode; }
                set { _employeeZipCode = value; }
            }

            string _employeeEmailId = string.Empty;
            public string EmployeeEmailId
            {
                get { return _employeeEmailId; }
                set
                {
                    if (value == null)
                        throw new ArgumentNullException("Employee EmailID can not be null");
                    _employeeEmailId = value;
                }
            }


            public EmployeeDetails()
            {
                this._employeeId = 0;
                this._employeeFirstName = string.Empty;
                this._employeeMiddleName = string.Empty;
                this._employeeLastName = string.Empty;
                this._employeeFullName = _employeeFirstName + _employeeMiddleName + _employeeLastName;
                this._employeeDateOfBirth = DateTime.MinValue;
                this._employeeGender = string.Empty;
                this._employeeDepartmentId = 0;
                
                this._employeeDesignation= string.Empty;
                this.DateOfJoining = DateTime.MinValue;
                this._employeementType = string.Empty;
                this._employeeManagerId = 0;
                this._isEmployeeOnPermanentPayroll = 'Y';
                this._employeePayScale = 0;
                this._employeeBaseSalary = 0;
                this._employeeQualifications= string.Empty;
                this._experienceOfWork = 0;
                this._employeePhoneNumber=string.Empty;
                this._employeeAddressLine1 = string.Empty;
                this._employeeAddressLine2 = string.Empty;
                this._employeeFullAddress = _employeeAddressLine1 + _employeeAddressLine2;
                this._employeeCity= string.Empty;
                this._employeeState= string.Empty;
                this._employeeCountry= string.Empty;
                this._employeeZipCode= string.Empty;
                this._employeeEmailId= string.Empty;
            }

            public EmployeeDetails(int employeeId, string employeeFName, string employeeMName, string employeeLName, DateTime dob, string gen,int empdeptId, string empdesignation, DateTime doj,string emptype,int empManagerId,char isPermPayroll,int empPayScale, decimal empBaseSal,string empQual, int empExpWork, string empPhoneNum, string empAddLine1, string empAddLine2,string empCity, string empState, string empCountry, string empZipCode, string empEmailId, int deptId, string deptCode, string deptName, int schId, string schCode, string schName, string schRegNum, DateTime estYear, string affBoard, string motto, string vision, string schDesc, string addLine1, string addLine2, string city, string state, string country, string zipCode, string emailID, string schURL, string schPhoneNum) : base(deptId, deptCode, deptName, schId, schCode, schName, schRegNum, estYear, affBoard, motto, vision, schDesc, addLine1, addLine2, city, state, country, zipCode, emailID, schURL, schPhoneNum)
            {
                this._employeeId = employeeId;
                this._employeeFirstName = employeeFName;
                this._employeeMiddleName = employeeMName;
                this._employeeLastName = employeeLName;
                this._employeeFullName = _employeeFirstName + _employeeMiddleName + _employeeLastName;
                this._employeeDateOfBirth = dob;
                this._employeeGender = gen;
                this._employeeDepartmentId = empdeptId;

                this._employeeDesignation = empdesignation;
                this.DateOfJoining = doj;
                this._employeementType = emptype;
                this._employeeManagerId = empManagerId;
                this._isEmployeeOnPermanentPayroll = isPermPayroll;
                this._employeePayScale = empPayScale;
                this._employeeBaseSalary = empBaseSal;
                this._employeeQualifications = empQual;
                this._experienceOfWork = empExpWork;
                this._employeePhoneNumber = empPhoneNum;
                this._employeeAddressLine1 = empAddLine1;
                this._employeeAddressLine2 = empAddLine2;
                this._employeeFullAddress = _employeeAddressLine1 + _employeeAddressLine2;
                this._employeeCity = empCity;
                this._employeeState = empState;
                this._employeeCountry = empCountry;
                this._employeeZipCode = empZipCode;
                this._employeeEmailId = empEmailId;



            }

            //These Child classes ought to have same access specifier for the overridden Method in the Child Classes.
            public override void displayOrganizationDetails()
            {
                Console.WriteLine($"Employee Organiization details: School ID : {SchoolId} School Code : {SchoolCode} School Name : {SchoolName} Registration Number : {RegistrationNumber} Establishment Year : {EstablishmentYear} Affiliation Board : {AffiliationBoard} Motto : {Motto} Vision : {Vision} Description : {Description} AddressLine1 : {AddressLine1} AddressLine2 : {AddressLine2} Full address : {FullAddress} City : {City} State : {State} Country : {Country} ZipCode : {ZipCode} EmailId : {Email} Website URL : {WebsiteURL} Phone Number : {SchoolPhoneNumber}");

            }

            public override void displayAddress()
            {
                Console.WriteLine($"Employee Org. Address: {FullAddress} City : {City} State : {State} Country : {Country} Zip Code : {ZipCode} Email : {Email} Phone Number : {SchoolPhoneNumber}");
            }


            /*Methods Hiding using new Keyword.
            
             */
            public new void displayCountry()
            {
                Console.WriteLine("Country : Bihar");
            }

            static void Main(string[] args)
            {       
                //Constructor Chaining Implementation.
                EmployeeDetails details = new EmployeeDetails(1, "Anupam","","Kumari", DateTime.Parse("1996-01-10"),"F",2,"Director", DateTime.Parse("2018-04-18"),"Admin",2,'Y',9,100000,"Graduate",10,"8123414499","Khagaria","Bihar","Khagaria","Bihar","India","852161","aupam@skrintlschool.com", 2, "PHY", "Physics", 20, "SKRPAT02", "SKR International School Patna", "SKRPATICSE", DateTime.Parse("2018-04-18"), "CBSE", "Education for All", "Education for India", "ICSE Affiliated School with AI Labs", "Vitthal VR Complex", "Saguna More Danapur", "Patna", "Bihar", "India", "800040", "info@skrschool.com", "www.skrschool.org", "8123414499");

                //Polymorphism Implementation.
                OrganizationDetails orgDet;        // Reference of the Parent Class.
                orgDet = new DepartmentDetails();  // Object of the Child Class whose method we would like to call.
                orgDet.displayOrganizationDetails();
                orgDet.displayAddress();

                orgDet = new EmployeeDetails();
                orgDet.displayOrganizationDetails();
                orgDet.displayAddress();
                orgDet.displayCountry();


                orgDet = new OrganizationDetails();
                orgDet.displayOrganizationDetails();
                orgDet.displayAddress();

                Console.ReadKey();
            }




        }
    
}
