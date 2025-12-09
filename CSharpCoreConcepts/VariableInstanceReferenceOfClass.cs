using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class VariableInstanceReferenceOfClass
    {
        int rollNumber;
        string? studentName;
        object? studentDetails;
        bool registeredStudent;

        /*Class:
        =======          
        It is a "User" defined "type".
        e.g. We say "String" is a Data Type but it was not born as a Data-Type rather it was developed as a Class.
        So, String is a 'pre-defined Class' in Our Libraries and that we are calling as a 'Data-type' Now.
        Hence "Every Class is a Data Type".

        It may be "pre-defined Class" or "user-defined Class" or whatever it is ,It is going to be a "Data Type/User Defined Type".

        We can not consume a Class Directly.
        In order to consume a Class,we need to create a Copy of it.

        e.g. We know "int" is a Data Type.
        Can we Consume int like -> int = 100;
        Answer is "No" because int is only a blue print for our particular Data.
        It does not have a Memory Allocation.
        If we want Memory Allocation for it ,then We should write -> int val=100;
        Here 'val' is actually a Copy of Type "int".

        Similarly, If we write -> string="sampat";
        We can not consume string like this because like "int" ,string is also a pre defined Class and we can not consume a user defined Class Directly.
        We need to create a Copy of it.
        so,we can write -> string name="Sampat";
        Here 'name' is actually a Copy of user-defined class "string".

        Thus In order to Consume a User defined type like 'Class', We need to allocate Memory for it and
        It can be done through creating a Copy of the Class.

        We can also understand it as If we have to build a House to live in then first we need to have a Plan in order to build a House.
        We can not live inside a "Plan" rather we need to construct our House to live into.

        Similarly, user defined types like int,string etc are user defined class which are just the "Plan" of the House.

        In order to use these Plans, we need to allocate Memory to live in and that is done by creating a Copy of it.
        Memory allocation is done by Creating a Copy of it.

        Thus, a Data Type is just a "Plan" and a Copy of it actually the Implementation of the "Plan".
            
         
        Variable :
        =========           
        It is Copy of a Class that is not Initialized i.e. Memory allocation is not done Here.
         
        */


        static void Main(string[] args)
        {

            /*
              I want to just print the Values of the Variables declared above 

              Console.WriteLine("Roll Number:" + rollNumber);

              The above line of Code will throw an Error because rollNumber is a 'Instance Variable' or 'Non-Static Variable'.

              Accessing a 'Non-Static' member of a Class from a 'Static' Block:
              ==============================================================
              We can not access a Non-Static member of a Class from a "Static" Block.

              So, In order to access this 'Non-Static' variable inside this 'Static' Block, we will create an 'Instance of a Class' i.e. Copy of this Class.

              VariableInstanceReferenceOfClass varinstref;

              Console.WriteLine("Roll Number:" + varinstref.rollNumber);

              We shall again get an Error as 'varinstref' here is nothing but a Variable of the Class 'VariableInstanceReferenceOfAClass'.

              Variable of the Class:
              =====================
              Variable of the Class means 'A Copy of the Class that is not Initialized.'

              Hence we need to create an Instance of the Class and Instances of Class is created by using "new" Keyword.

              Instance of a Class:
              ===================
              It is a Copy of the Class that is initialized by using the "new" keyword.


              */

            VariableInstanceReferenceOfClass varinstref = new VariableInstanceReferenceOfClass();

            /*We can also write the above line of Code as ->
            VariableInstanceReferenceOfAClass varinstref;
                                        varinstref = new VariableInstanceReferenceOfAClass(); 

            We have just broken the Code into Two lines. It is actually the same.

            'varinstref' is actually a Copy/Instance of the Class and since Memory is allocated for the Instances so we have a Memory Allocation for the Class now.
            We can access the "Instance-Variable" or "Non Static" Variable rollNumber now and print it.

           */

            Console.WriteLine("Roll Number:" + varinstref.rollNumber);

            VariableInstanceReferenceOfClass varinstref1 = new VariableInstanceReferenceOfClass();
            VariableInstanceReferenceOfClass varinstref2 = new VariableInstanceReferenceOfClass();

            /*Here we have created a Total of three Instances of the Class.
            So Three times Memory allocation shall be done because we know that Memory allocation is done as many times as we create an Instance of the Class.

            Hence these three Instances or Memory allocations are different.
            We can prove that by the initializing the Variables with different values through these different Instances.

            *Very Important Point : The Memory that is allocated for One Instance is never shared with another Instance.
                                    Thus any modification made to the Member of One Instance will not reflect to the Members of Second Instance.
                                    Every Instance is "Unique" in itself.
            */

            varinstref.rollNumber = 1;
            Console.WriteLine("rollNumber variable has been asigned value through first Instance :" + varinstref.rollNumber);

            varinstref1.rollNumber = 2;
            Console.WriteLine("rollNumber variable has been asigned value through Second Instance:" + varinstref1.rollNumber);

            varinstref2.rollNumber = 3;
            Console.WriteLine("rollNumber variable has been asigned value through Second Instance:" + varinstref2.rollNumber);

            VariableInstanceReferenceOfClass varinstref3 = new VariableInstanceReferenceOfClass();
            varinstref3.rollNumber = 4;
            VariableInstanceReferenceOfClass varinstref4;
            varinstref4 = varinstref3;

            /*Reference of Class:
              ==================
             In the above lines of Code 'varinstref4' is a Reference of the Class.
                          Here 'varinstref4' variable of the Class is again initialized by the Instance 'varinstref3'.
                          It is simply a pointer to the Instance "varinstref3".
                          Moreover "varinstref4" will not have a Separate Memory Allocation and both varinstref3 and varinstref4 will consume the same Memory allocation in this case.
                          Hence we must remeber that varinstref4 is Not Uninitialized rather it is initialized by varinstref3.
                          If varinstref4 was not initialized then it would have been a Variable and we can not call a member through Variable.
                          Rather we can call a Member through a Reference which itself is Initialized.

            Thus,Reference is actually a Copy of the Class that is Initialized by using an existing Instance.
            References do not have a Memory.
            It is Pointer to an Instance.
            Also Every Modification we perform on the members using Instance will reflect the same when we access those members through Reference and Vice-Versa.
            i.e. They will have similar values as both are consuming the same Memory Allocation.
            But it can be used like an Instance.

            */



            Console.WriteLine("roll number of Instance varinstref3:" + varinstref3.rollNumber);
            Console.WriteLine("roll number of the reference varinstref4:" + varinstref4.rollNumber);
            Console.WriteLine("Thus it proves that Reference varinstref4 and instance varinstref3 consume the same Memory allocation");
            Console.ReadLine();


        }




    }
}
