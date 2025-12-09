using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpCoreConcepts
{
    public class MultiThreadingDemo
    {
        public void f()
        {
            /*Sequential Threading BEGIN*/

            //f1();
            //f2();

            /*Sequential Threading END*/

            /*MultiThreading BEGIN*/
            ThreadStart T1 = new ThreadStart(f1);
            ThreadStart T2 = new ThreadStart(f2);
            ThreadStart T3 = new ThreadStart(f3);
            ThreadStart T4 = new ThreadStart(f4);
            ThreadStart T5 = new ThreadStart(f5);

            Thread t1 = new Thread(T1);
            Thread t2 = new Thread(T2);
            Thread t3 = new Thread(T3);
            Thread t4 = new Thread(T4);
            Thread t5 = new Thread(T5);

            //t1.Start();
            //t2.Start();
            //t3.Start();
            //t4.Start();
            //t5.Start();

            /*MultiThreading END*/

            /*Thread manipulation BEGIN*/

            /*[1] Total 4 Threads, but 3 are depending upon 1 to complete and then run all 3*/




            /*[2]First Thread should run for 500 milli second alone, after that 2nd thread will join parallel.*/

            //t1.Start();
            //t1.Join(500);
            //t2.Start();
            //t3.Start();
            //t4.Start();
            //t5.Start();

            /*Thread manipulation END*/


            ThreadPool.SetMaxThreads(10,5);
            t1.Priority = ThreadPriority.Highest;
            t5.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();

        }

        public void f1()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Inside f1....{0}", i);

            }
        }

        public void f2()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Inside f2....{0}", i);
            }
        }

        public void f3()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Inside f3....{0}", i);
            }
        }

        public void f4()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Inside f4....{0}", i);
            }
        }

        public void f5()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Inside f5....{0}", i);
            }
        }

        static void Main(string[] args)
        {

            MultiThreadingDemo demoThreading = new MultiThreadingDemo();
            demoThreading.f();
            //Console.ReadKey();
        }


    }
}
