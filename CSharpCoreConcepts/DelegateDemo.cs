using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class DelegateDemo
    {
        delegate int NumberChanger(int n);

        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

        /*  The following example demonstrates the use of delegate. 
            The delegate printString can be used to reference method that takes a string as input and returns nothing.
            We use this delegate to call two methods, the first prints the string to the console, and the second one prints it to a file : 
            When the above code is compiled and executed, it produces the following result −
            The String is: Welcome

       */

        static FileStream fs;
        static StreamWriter sw;

        // delegate declaration
        public delegate void printString(string s);


        // this method prints to the console
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is: {0}", str);
        }

        //this method prints to a file
        public static void WriteToFile(string s)
        {
            fs = new FileStream("D:\\PrintStringDelegatesDemo.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        // this method takes the delegate as parameter and uses it to
        // call the methods as required
        public static void sendString(printString ps)
        {
            ps("Welcome!!! Sampat. ");
        }
        static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());

            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());


            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);
            sendString(ps1);
            sendString(ps2);

            Console.ReadKey();
        }


    }

}
        
       




        

