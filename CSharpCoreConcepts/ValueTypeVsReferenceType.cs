using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    internal class ValueTypeVsReferenceType
    {
        
            public string? Name;
            int a = 10;
            int b;


            public ValueTypeVsReferenceType()
            {
                b = a;  // b gets a copy of a
                b = 20;
            }
        static void Main(string[] args)
            {
                ValueTypeVsReferenceType p1 = new ValueTypeVsReferenceType();
                p1.Name = "Sampat";

                ValueTypeVsReferenceType p2 = p1;  // p2 references the same object
                p2.Name = "AI Enthusiast";

                Console.WriteLine(p1.Name); // Output: AI Enthusiast

                Console.WriteLine(p1.a); // Output: 10
                Console.WriteLine(p1.b);
        }


    }
    
}
