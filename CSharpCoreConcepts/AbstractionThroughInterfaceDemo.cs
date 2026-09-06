using Microsoft.Diagnostics.Tracing.Parsers.Clr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpCoreConcepts
{
    
        /*
                Abstraction  : Provide exposure that which is required, and hide that which is not required
                -----------

                These three features were available till 2nd Generation i.e.up to C++
                --> Encapsulation
                --> Inheritance
                --> Polymorphism

                Abstraction: This fourth features first came in Java, and made it in 3rd Gen.


                class MyClass
                {
                    public void f1() { ....coding....}

                    public void f2() { ....coding...}

                    public void f3() { ....coding...}
                }

                Program.cs
                ----------




                admin  -------> f1, f2 and f3
                staff  -------> f2 and f3
                vendor  ------> f3

                Interface :
                ===========
                -- > how many permissions that many interface. It doesn't take any memory and not even disturbs your existing class.        

                -- > Reference of the Interface and Object of the Class.

                This does not take any memory, hence, Can not get Instantiated and is a helping element.

                Using this technique, abstraction gives access to various levels.


                restaurant -- 10 foods

                500 Rs Coupon (Like Interface) -->   3 foods (e.g. Access to Three Methods)
                We do not eat Coupon rather we eat the food that is permitted using that Coupon.
 
                1000 -->  7 foods


                [ Qn1] Abstraction in C# can be explained as representing the essential features without representing the non-essential details. 
                In other words exposing required properties, features or functionalities through an object and hiding all other functionalities to be accessed through that object is called 'Abstraction' in OOPs.
                Hence, Abstraction is all about providing exposure to that which is required, and hiding that which is not required.

                Abstraction in C# can be obtained through two Features: 
                [a] using Interface, and 
                [b] using Abstract Class.

                But before proceeding with implementing Abstraction, we need to examine which approach would be better by taking care of below two parameters:

                [a] analyze if there is any "hierarchal relationship" to determine the access permissions.

                Example: In an Organization, if there are following roles: Manager > Admin > Employee.

                Manager would be able to see the details about both Admin and Employee.

                Admin would be able to see the details about Employee.

                But Employee would not be able to see details for either the Manager or the Admin.

                e.g. 
        
                class CSharpTestImplementAbstraction
                {
                    public void  f1()
                    {
                        Console.WriteLine("This is Manager Data");
                    }

                    public void  f2()
                    {
                        Console.WriteLine("This is Admin Data");
                    }

                    public void  f3()
                    {
	                    Console.WriteLine("This is Employee Data");
	                }
                }

                Here, Manager have access -- > f1(), f2(), f3().

                Admin can have access -- > f2(),f3(),

                Employee can have access -- > only f3()

                We can clearly see that there exists a Hierarchal relationship.

                Here, we can go for both 'Interface' as well as 'Abstract Class'.

                But How to decide which approach to take forward?
                ================================================

                This can be answered by analyzing if we need other fields, methods in the Class which need to initialized and re-used 
                i.e. creation of Object is needed or not?
                If yes, then clearly we need to go for a method which would need 'Memory allocation', and 
                then only 'Abstract' class is the way forward because 'Interface' does not consume any Memory i.e. (we can not create an Object of the Interface).

                Note: Abstract class can contain Abstract functions (to be abstracted) as well as Common Functions also which can be used regardless of permission.

                Note: If no fields or methods need to be initialized i.e. no Object creation and Memory allocation is needed, then we can go for 'Interface' as well.

                If there is absolutely no Hierarchal relationship, then we have to go only for 'Interface' as C# does not allow 'Multiple Inheritance'.

                Using Interface:
                ===============

        */


                interface Interface1
                {
                    void Level_1();
                    void Level_2();
                    void Level_3();
                }

                interface Interface2
                {
                    void Level_2();
                    void Level_3();
                }

                interface Interface3
                {
                    void Level_3();
                }


   


    public class AbstractionThroughInterfaceDemo : Interface1,Interface2,Interface3
    {
        public void Level_1()
        {
        Console.WriteLine("This is level 1 data");
        }

        public void Level_2()
        {
        Console.WriteLine("This is level 2 data");
        }

        public void Level_3()
        {
        Console.WriteLine("This is level 3 data");
        }

        static void Main(string[] args)
        {
            string role = "Manager";
            if (role == "Manager")
            {
                Interface1 objInterface1 = new AbstractionThroughInterfaceDemo();
                objInterface1.Level_1();
                objInterface1.Level_2();
                objInterface1.Level_3();
                

                Console.WriteLine("Manager has access to all levels: level-1 level-2 and level-3");
                Console.ReadKey();
            }
            else if (role == "admin")
            {
                Interface2 objInterface2 = new AbstractionThroughInterfaceDemo();

                objInterface2.Level_2();
                objInterface2.Level_3();
                Console.WriteLine("Admin has access to level-2 and level-3");
                Console.ReadKey();
            }

            else if (role == "Employee")
            {
                Interface3 objInterface3 = new AbstractionThroughInterfaceDemo();
                objInterface3.Level_3();
                Console.WriteLine("Staff has access to level-3 only");
                Console.ReadKey();
            }
        
        }
    }




    
}
