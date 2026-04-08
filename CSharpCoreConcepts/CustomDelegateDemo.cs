using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class CustomDelegateDemo
    {
        int s = 10;
        public delegate int MyDelegate(int n);   //Defining delegate
        public void f()
        {

            MyDelegate del1 = new MyDelegate(Add);   //Instantiating delegate
            MyDelegate del2 = new MyDelegate(Multiply);

            /*Two Single Cast Delegate*/
            del1(5);            
            del2(5);            // This is sequential and not parallel like ThreadStart delegate

            /*Multi Cast Delegate. Here we can make use of Single Multi Cast delegate to achieve output of Two Single Cast Delegates del1(5) and del2(5).*/
            MyDelegate delMulti = del1 + del2;      
            delMulti(5);

            Console.WriteLine("The value of s is {0}", s);      // 
        }
        public int Add(int n)
        {
            s = s + n;
            return s;
        }
        public int Multiply(int n)
        {
            s = s * n;
            return s;
        }

        static void Main(string[] args)
        {
            CustomDelegateDemo objCustomDelegateDemo = new CustomDelegateDemo();
            objCustomDelegateDemo.f();
            Console.ReadKey();
        }
    }
}
