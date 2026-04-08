using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    public class StringBuilderDemo
    {
        public void Concatenate_Names()
        {
            string name;

            StringBuilder names = new StringBuilder();

            Console.WriteLine("4 members names");
            for (int n = 0; n < 4; n++)
            {
                name = Console.ReadLine();
                names.Append(name);
                names.Append(", ");
            }

            Console.WriteLine("All names are {0}", names);

        }

        static void Main(string[] args)
        {
            StringBuilderDemo objStringBuilderDemo = new StringBuilderDemo();
            objStringBuilderDemo.Concatenate_Names();
            Console.ReadKey();
        }
    }
}
