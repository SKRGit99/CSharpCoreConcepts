using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class ThreadingDemo
    {
        /*The following program demonstrates 'Main' thread execution. */

        //static void Main(string[] args)
        //{
        //    Thread th = Thread.CurrentThread;
        //    th.Name = "MainThread";
        //    Console.WriteLine("This is {0}", th.Name);
        //    Console.ReadKey();
        //}


        /* 'Main' thread execution Ends */



        /*The following program demonstrates the concept – ThreadCreation.*/

        //public static void CallToChildThread()
        //{
        //    Console.WriteLine("Child thread starts");
        //}
        //static void Main(string[] args)
        //{
        //    ThreadStart childref = new ThreadStart(CallToChildThread);
        //    Console.WriteLine("In Main: Creating the Child thread");
        //    Thread childThread = new Thread(childref);
        //    childThread.Start();
        //    Console.ReadKey();
        //}

        /*  ThreadCreation Ends.*/


        /*Managing Threads: The Thread class provides various methods for managing threads.
                            The following example demonstrates the use of the sleep() method for making a thread pause for a specific period of time.  
        
                            When the above code is compiled and executed, it produces the following result: 
                            In Main: Creating the Child thread
                            Child thread starts
                            Child Thread Paused for 5 seconds
                            Child thread resumes

        */


        //public static void CallToChildThread()
        //{
        //    Console.WriteLine("Child thread starts");
        //    // the thread is paused for 5000 milliseconds
        //    int sleepfor = 5000;
        //    Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
        //    Thread.Sleep(sleepfor);
        //    Console.WriteLine("Child thread resumes");
        //}
        //static void Main(string[] args)
        //{
        //    ThreadStart childref = new ThreadStart(CallToChildThread);
        //    Console.WriteLine("In Main: Creating the Child thread");
        //    Thread childThread = new Thread(childref);
        //    childThread.Start();
        //    Console.ReadKey();
        //}


        /*Managing Threads Ends*/


        /*Set Max Threads and Priority of Threads:
        
        Let's see an example where we are setting max number of running threads out of all initiated threads to avoid deadlock and also changing the priority of the thread. 
        The high priority thread can be executed first.
        But it is not guaranteed because thread is highly system dependent.
        It increases the chance of the high priority thread to execute before low priority thread.
        
        The output is unpredictable because threads are highly system dependent. It may follow any algorithm preemptive or non-preemptive.
        Player1 is running
        Player3 is running
        Player2 is running */


        public void Thread1()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + " is running");
        }
    
        public static void Main()
        {
            ThreadingDemo mt = new ThreadingDemo();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            t1.Name = "Player1";
            t2.Name = "Player2";
            t3.Name = "Player3";
            t3.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Normal;
            t1.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }

}
    
    

    



