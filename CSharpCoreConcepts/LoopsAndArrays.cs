using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class LoopsAndArrays
    {

        /// <summary>
        /// Display "Welcome" 5 times
        /// </summary>
        public void for_loop_1()
        {
            for (int n = 1; n <= 5; n++)
            {
                Console.WriteLine("Welcome");
            }
        }

        /// <summary>
        /// Go on asking user about marks obtained in various subjects.
        /// When user says "no" to a question "Any more marks to enter?(yes/no)"
        /// then calculate total marks and display.
        /// </summary>
        public void while_loop_1()
        {
            int marks, tot = 0;
            string ans = "yes";

            while (ans == "yes")
            {

                Console.WriteLine("Enter the marks");
                marks = Convert.ToInt32(Console.ReadLine());
                tot = tot + marks;

                Console.WriteLine("Any more marks to enter?(yes/no)");
                ans = Console.ReadLine();

            }


        }

        public void do_while_loop_1()
        {
            int marks, tot = 0;
            string ans = "yes";

            do
            {
                Console.WriteLine("Enter the marks");
                marks = Convert.ToInt32(Console.ReadLine());
                tot = tot + marks;

                Console.WriteLine("Any more marks to enter?(yes/no)");

                ans = Console.ReadLine();


            } while (ans == "yes");


        }

        /// <summary>
        /// Assign 5 int values to an array and display them
        /// </summary>
        public void foreach_1()
        {
            int[] x = new int[5] { 98, 76, 78, 54, 70 };

            foreach (int n in x)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// Accept an array of 5 int values.
        /// Find max value
        /// </summary>
        public void Array_1()
        {
            int[] Marks = new int[5];
            int n = 0;

            Console.WriteLine("Enter 5 int values");

            // Accepting data from user
            for (int i = 0; i < 5; i++)
            {
                Marks[i] = Convert.ToInt32(Console.ReadLine());

            }

            // Complex manipulation
            n = Marks[0];
            foreach (int k in Marks)
            {
                if (k > n)
                {
                    n = k;
                }
            }

            Console.WriteLine("Max value is {0}", n);

        }

        public void Array_2()
        {
            int[] Marks = new int[5];

            Console.WriteLine("Enter 5 int values");

            // Accepting data from user
            for (int i = 0; i < 5; i++)
            {
                Marks[i] = Convert.ToInt32(Console.ReadLine());

            }

            // Complex manipulation
            for (int i = 0; i < 4; i++)
            {
                if (Marks[i] > Marks[i + 1])
                {
                    int p;
                    p = Marks[i];
                    Marks[i] = Marks[i + 1];
                    Marks[i + 1] = p;
                }
            }

            Console.WriteLine("Min value is {0}", Marks[4]);

        }

        public void Array_3()
        {
            int[] Marks = new int[5];

            Console.WriteLine("Enter 5 int values");

            // Accepting data from user
            for (int i = 0; i < 5; i++)
            {
                Marks[i] = Convert.ToInt32(Console.ReadLine());

            }

            // Complex manipulation

            for (int j = 4; j >= 1; j--)
            {

                for (int i = 0; i < j; i++)
                {
                    if (Marks[i] > Marks[i + 1])
                    {
                        int p;
                        p = Marks[i];
                        Marks[i] = Marks[i + 1];
                        Marks[i + 1] = p;
                    }
                }

            }

            Console.WriteLine("\n");
            foreach (int v in Marks)
            {
                Console.WriteLine(v);
            }

        }

        public void Check_Prime()
        {
            int n;
            int flag = 0;

            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            // 25
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    flag = 1;
                    break;
                }

            }

            if (flag == 0)
            {
                Console.WriteLine("Prime");
            }


        }

        /// <summary>
        /// Accept a 3X2 matrix and display it
        /// </summary>
        public void Array_2D()
        {
            int[,] arr = new int[3, 2];
            Console.WriteLine("Enter 6 numbers");
            for (int r = 0; r < 3; r++)             // this is as per rows
            {
                for (int c = 0; c < 2; c++)         // as per columns
                {
                    arr[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Above values in 3X2 matrix format are :\n");
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write(arr[r, c] + "\t");
                }

                Console.WriteLine();
            }

        }



        static void Main(string[] args)
        {
            LoopsAndArrays obj = new LoopsAndArrays();

            obj.for_loop_1();

            obj.while_loop_1();

            obj.foreach_1();

            obj.Array_1();

            obj.Array_2();

            obj.Array_3();

            obj.Check_Prime();

            obj.Array_2D();

            Console.ReadKey();

        }


    }
}
