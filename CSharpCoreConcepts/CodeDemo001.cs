using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class CodeDemo001
    {
        private int _OMPhoneNumber;

        internal string _name = string.Empty;

        public string _description = string.Empty;

        public string _fatherName = string.Empty;

        public string _villageName = string.Empty;
        
        public void displayChachaName()
        {
            Console.WriteLine("SAMPAT KUMAR RAHUL");
        }

       
    }

    public class DepartmentDemo001
    {

        /* 1. Field = Variable - Starts */
        private int departmentId;
        protected string departmentCode = string.Empty;

        internal DateTime departmentEstablishedDate;
        protected internal decimal departmentSalary;
        public string departmentName = string.Empty;


        /* Field Ends */


        /* 2. Constructor starts - Default or Parameterless */
        public DepartmentDemo001()
        {
            departmentId = 101;
            departmentCode = "IT";
            departmentEstablishedDate = new DateTime(2010, 5, 15);
            departmentSalary = 50000.00m;
            departmentName = "Information Technology";
        }

        /* Constructor ends - Default or Parameterless */

        /* 3. Method starts */
        private void displayDepartmentDetails()
        {
            departmentId = 110; 
            departmentCode = "CS"; 
            departmentEstablishedDate = new DateTime(2015, 3, 10); 
            departmentSalary = 60000.00m; 
            departmentName = "Computer Science";

            Console.WriteLine("Department ID: " + departmentId);
            Console.WriteLine("Department Code: " + departmentCode);
            Console.WriteLine("Department Established Date: " + departmentEstablishedDate);
            Console.WriteLine("Department Salary: " + departmentSalary);
            Console.WriteLine("Department Name: " + departmentName);
        }


        public void displayDepartmentName()
        {
            Console.WriteLine("Department Name: " + departmentName);
        }

        protected void displayDepartmentCode()
        {
            Console.WriteLine("Department Code: " + departmentCode);
        }

        protected internal void displayDepartmentSalary(int empGrade)
        {
            if (empGrade == 1)
            {
                Console.WriteLine("Department Salary: $50,000");
            }
            else if (empGrade == 2)
            {
                Console.WriteLine("Department Salary: $60,000");
            }
            else
            {
                Console.WriteLine("Invalid employee grade.");
            }
        }



        /* Method Ends */

        static void Main(string[] args)
        {
            DepartmentDemo001 dept = new DepartmentDemo001();
            dept.displayDepartmentDetails();
            
        }


    }

    public class EmployeeDemo001 : DepartmentDemo001
    {
        private int employeeId;
        public string employeeName = string.Empty;
        protected string employeeDepartment = string.Empty;

        protected internal long employeePhoneNumber;

        internal decimal employeeSalary;
        private void displayEmployeeId()
        {
            Console.WriteLine("Employee ID: " + employeeId);
        }
        public void displayEmployeeDepartmentDetails(string deptName)
        {
            Console.WriteLine($"Employee Department Code : {departmentCode}, Employee Department Name: {deptName}");
        
        }
        public void displayEmployeeSalary(int empGrade)
        {
            
        }

        static void Main(string[] args)
        {
            DepartmentDemo001 dept = new DepartmentDemo001();

            EmployeeDemo001 emp = new EmployeeDemo001();
            emp.employeeId = 1;
            emp.employeeName = "Om Anand";

            emp.employeeDepartment = "IT";
            emp.employeePhoneNumber = 1234567890;

            emp.displayEmployeeDepartmentDetails("IT");

        }
    }
}
