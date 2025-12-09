using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class TypesOfVariablesInClass
    {
        /*
            Variable:
            ========
            It is a Container for storing Values inside a Class.

            There are Four different types of Variables that can be declared inside a Class.
            
            Life Cycle of Class:
            ===================
            It is the Point from which we start the execution to the Point it ends is called Life Cycle.
            
            Non-Static /Instance Variables: 
            ==============================
            Memory is allocated only after an Instance of the Class is created.
            So,Non-Static/Instance members can not be accessed without creating an Instance of the Class.

            Non-Static/Instance variables are initialized only after creating the Instance of Class as well as each and every time the Instance of Class is created.
         
            In the Life Cycle of Class, Instance variables are initialized as many times as the Instance of the Class is created.

            Initialization of Non-Static/Instance Variables:
            ===============================================
            It is associated with 'Instance Creation' and 'Constructor Calling'.

            So, We can initialize the Instance variables through the Constructor also.

            
            Static Variables:
            ================
            If a variable is declared using a 'Static Modifier' Or If a Variable is declared under any 'Static Block' then We call those variables as Static Variables.

            Static variables of a Class are initialized immediately once the execution of Class starts.

            So,once the Execution of Class starts,immediately the Memory is allocated for the Static Variable.

            So,It does not Matter if we create the Instance or not, Static variable shall be initialized immediately after the Class Execution starts.

            
            Can we Initialize Static Variables through Construtors Calling?
            ===============================================================
            Yes ,we can but it will simply go and Override the existing Value.
            Thus,there is no chance of modifying the Value so why to waste the resources by creating Multiple Memory allocations or Copies of the Static Variable.
            
            So,generally we do not Initialize Static Variables through Constructors at all.

            Very Very Important:
            ===================
            In the Life Cycle of a Class , A static variable is initialized only Once.

            
            Constant Variables:
            ==================
            If a variable is declared by a Keyword "CONST" ,we call it as a Constant Variable and these Constant variables can not be modified once after their Declaration.
            Hence, It is "must" that we initialize the Constant variable at the time of Declaration only.

            Again "only one Copy" is created because if say Ten Instances means Ten Copies shall be created but if we can not modify the Value itself, then there is no point of creating multiple Instances.
            It shall be a waste of Resources if we do that.


            Remember :
            =========
            The behaviour of a Constant Variable will be similar to the Static variables.
            i.e. It shall be initialized one and only one time during the Life Cycle of a Class immediately once the execution of Class starts and does not require the Instance of the Class for access.

            
            'Static' Vs 'CONST' Variables:
            =============================
            The Only difference between the Static and Constant Variables is that Static can be modified but Constant variables can not be modified.


            ReadOnly Variables:
            ==================
            If a variable is declared using the 'readonly' keyword , we call that variable as readonly variable.
            These variables also can not be modified like Constants but after Initialization.

            The difference is that Constant variables can not be modified after "declaration" but readonly can not be modified after "Initialization".
            It is not necessary to initialize a readonly variable at the time of declaration, they can also be initialized under the Constructor.


            Non-Static/Instance Variable Vs readonly variable: 
            =================================================
            The behaviour of readonly variable is similar to the Non-Static/Instance Variable .i.e Initialized only after creating the Instance of the Class.
            The Memory allocation shall be made as many times as the Instance of Class is created.

            However the only difference is that Non-Static/Instance variables can be modified after Intialization but not readonly variables.


            Constant Vs ReadOnly variable?
            ==============================================================
            'Constant' is only one Copy through for the whole Class but 'readonly' has as many copies as the number of Instances of the Class is created.
            Constant is a fixed value for the whole Class but readonly is fixed value to the specific Instance of the Class. 
        
            How many Copies of/Memory allocation shall be here in this Code?
            There shall be Three Copies of readonly variable shall be here as three Instances of the Class is created.

           
         */

        /*It is Non-Static or Instance Variable*/
        int rollNumber;

        /*Static Variable as declared with static modifier*/
        static int batchID = 10;

        /*We have initialized the Constant variable at the time of Declaration only as it can not be modifed once it has been declared throughout the program.*/
        const string schoolName = "GyanSheela";

        /*We have declared the readonly variable but not initialized. We shall initialize it under the Constructor.*/
        readonly bool registeredStudent;
        


        public TypesOfVariablesInClass()
        {
            this.rollNumber = 10;
            batchID = 20; /*We are modifying Static Variable*/

            /*If we go to modify Constant variable ,It will throw error.
             
                schoolName = "New Era Public School";
             
            */

            /*We have initialized the readonly variable "registeredStudent*/

            this.registeredStudent = true;
            



        }


        public TypesOfVariablesInClass(int rollNum, bool regisDtudent)
        {
                this.rollNumber = rollNum;
                this.registeredStudent = regisDtudent;
        }




        static void Main(string[] args)
        {
            int classNumber = 10;
            Console.WriteLine("This is Static Variable as it has been declared inside a Static Block.");
            Console.WriteLine("Class Number:" + classNumber);
            Console.WriteLine("Class Number {0}", classNumber);
            Console.WriteLine(classNumber);

            /*Here we can straightway print the Value of Static Variable 'batchID' and CONST variable 'schoolName'
            i.e. We did not have to create an Instance of the Class to access the 'Static' and 'Constant Variables'.

            Very Important point to Remember :
            =================================
            Static and Constant Variables are intialized immediately after the Execution of the Class Starts.
            Hence we do not need to create an Instance of the Class.
            It proves that Static and CONST variables do not require Instance pf Class.

            */  

            Console.WriteLine("The Value of static variable BatchID:" + batchID);
            Console.WriteLine("Batch ID {0}", batchID);

            Console.WriteLine("The Value of Constant Variable schoolName:" + schoolName);
            Console.WriteLine("Constant Variable {0}", schoolName);

            /*But we can not go and access the Value assigned to Non Static/Instance Variable 'rollNumber'
                because Memory will be allocated for Non Static/Instance Variable only if we create an Instance of the Class.

            */

            /*First Instance of Class is created and Memory shall be allocated for Instance variable e.g. rollNumber. */
            TypesOfVariablesInClass typeVar = new TypesOfVariablesInClass();

           
            Console.WriteLine("The value of Roll Number:" + typeVar.rollNumber);
            Console.WriteLine("Roll Number: {0}", typeVar.rollNumber);

            Console.WriteLine("We have modified the value of Static Variable through Constructor Calling.");
            Console.WriteLine("Hence We can modify the Value of Static Variable during Program execution.");
            Console.WriteLine("Modified Value of Static Variable batchID:" + batchID);
            Console.WriteLine("New Value of BatchID:{0}\t", batchID);

            Console.WriteLine("But we can not modify the Values of CONST variable through out the Program.");
            Console.WriteLine("This is the Only difference between the Static and Constant Variables that Static can be modified but Constant variables can not be modified.");

            Console.WriteLine("Registered Student {0}", typeVar.registeredStudent);


            /*More Over ,If you want to Initialize the Static Variable through Instance it will not be possible as when you type "typeVar." to access static variable it will not Come Up.
            It will throw an error. 
            Hence we can can Initialize Static variables through Instance Creation.
            Static variables get initialized as the first line of code which gets execution as soon as Class is executed.

            Console.WriteLine("Batch ID:" +typevar.batchID);

            */


            /*Second Instance is created and again there shall be another Copy of variable 'rollNumber'.
              So, In total Two copies of Instance Variables shall be created Or Two times Memory allocation shall be done as we have have created Two Instance of The Class.
              As we know that Memory allocation shall be done for Instance Variables as many times as the Instance pf Class shall be created.

            */

            TypesOfVariablesInClass typevVar2 = new TypesOfVariablesInClass();


            /*In the above code since two Instances are created ,so there shall be Two times Memory allocation and Hence,Initialization of Instance Variable "rollNumber".
              But both of them shall have the same value as they are Initialized here only through Creating an Instance.

            */

            TypesOfVariablesInClass typeVar3 = new TypesOfVariablesInClass(20, true);
            Console.WriteLine("Roll Number:" + typeVar3.rollNumber);
            Console.WriteLine("Registered Student {0}", typeVar3.registeredStudent);

            /*We have Initialized the readonly variable through Two different Instances of the Class typeVar and typeVar3
            Now if I go to Modify the Value of readonly variable for Instance typeVar,is it possible?

            typeVar.registeredStudent = false;
            typeVar3.registeredStudent = true;

            It will throw error as we can not Modify the value of readonly variable after initialization through the repective Instance.

            Remember : Here ''readonly' variable 'registeredStudent' shall have different values for two different Instances typeVar and typeVar3.
            And once these Instances initialize this "readonly" variable ,It can not be modified again for those specific Instances.


             */
            typeVar.rollNumber = 15; /* See the Instance variable can be Modified after Initialization but not readonly variable */
            Console.ReadLine();
        }



    }
}
