using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class AsyncAndAwait
    {
        public async void f()
        {
            await Task.Run(new Action(f3));

            Task.Run(new Action(f1));

            Task.Run(new Action(f2));




        }


        public void f1()
        {
            for (int i = 1; i <= 3; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Inside f1 value is {0}", i);
            }
        }

        public void f2()
        {
            for (int i = 1; i <= 3; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Inside f2 value is {0}", i);
            }
        }

        public void f3()
        {
            for (int i = 1; i <= 3; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Inside f3 value is {0}", i);
            }
        }

        static void Main(string[] args)
        {
            AsyncAndAwait demo = new AsyncAndAwait();
            demo.f();
            Console.ReadKey();
        }
    }
}
