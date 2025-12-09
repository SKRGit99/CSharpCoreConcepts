using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class TestArrayDivion
    {
        public void divisionCheck()
        {
            int[] numArray1 = new int[6];
            int[] numDivided = new int[5];
            int numbersDivided = 0;

            Console.WriteLine("Enter the number");

            for (int i = 0; i < 6; i++)
            {
                numArray1[i] = Convert.ToInt32(Console.ReadLine());
            }



            for (int k = 0; k < numArray1.Length - 1; k++)
            {
                if (numArray1[k + 1] % numArray1[0] == 0)
                {
                    numbersDivided++;
                    numDivided[k] = numArray1[k + 1];
                }
            }



            foreach (int n in numDivided)
            {

                Console.WriteLine(n);



            }
        }

        public void array_ex()
        {
            int[] array = new int[6];
            Console.WriteLine("Enter 6 integer values into an array:");

            for (int i = 0; i < 6; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nResults:\n");

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"{array[i]} -- Numbers divisible by {array[i]} are: ");

                bool found = false;
                for (int j = 0; j < 6; j++)
                {
                    if (i != j && array[j] % array[i] == 0)
                    {
                        Console.Write(array[j] + ",");
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.Write("None");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            TestArrayDivion divCheck = new TestArrayDivion();
            //divCheck.divisionCheck();
            divCheck.array_ex();
        }

    }
}
