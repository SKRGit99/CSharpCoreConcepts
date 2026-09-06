using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class TestClass
    {
        int _num1;
        int _num2;

        public void boxingUnBoxingDemo()
        {
            _num1 = 100;

            Object obj = _num1;

            _num2 = (int)obj;

            Console.WriteLine(_num2);

            ArrayList arrLst = new ArrayList();
            arrLst.Add(_num1);

            if (arrLst[0] != null)
            {
                _num2 = (int)arrLst[0];
                Console.WriteLine(_num2);
            }
        }

        public void stringConcatenationDemo()
        {
            string resultStr = string.Empty;

            string? _str1 = "My Name is";
            string? _str2 = "Sampat";

            resultStr = System.String.Concat(_str1,_str2);
           

            Console.WriteLine(resultStr);

            string[] arrStr = new string[]{ "My", "name", "Sampat"};

            resultStr = System.String.Concat(arrStr);

            Console.WriteLine(resultStr);

        }

        public void linqDemo()
        {
            List<int> numList1 = new List<int> { 1, 2, 3, 4, 5, 6 };

            // Traditional foreach filtering
            List<int> filteredList = new List<int>();
            foreach (int num in numList1)
            {
                if (num > 2)
                {
                    filteredList.Add(num);
                }
            }

            Console.WriteLine("Filtered with foreach:");
            foreach (int n in filteredList)
            {
                Console.WriteLine(n);
            }

            // LINQ query filtering
            IEnumerable<int> filteredList3 = from n in numList1
                                             where n > 2
                                             select n;

            Console.WriteLine("Filtered with LINQ:");
            foreach (int n in filteredList3)
            {
                Console.WriteLine(n);
            }

            // Or print all at once
            Console.WriteLine("LINQ result: " + string.Join(", ", filteredList3));
        }


        static void Main(string[] args)
        {
            TestClass tst = new TestClass();
            tst.boxingUnBoxingDemo();

            tst.stringConcatenationDemo();

            tst.linqDemo();

            Console.ReadKey();
        }
    }
}
