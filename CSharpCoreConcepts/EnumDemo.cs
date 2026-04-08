using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    /*By default the underlying type of each element in the enum is int. If you try with above example to convert to integer then you can see the output:Temperature value is..1*/

    /*How to retrieve enum values*/
    public class EnumDemo
    {
       enum Temperature
        {
            Low,
            Medium,
            High,
        };
        private void button1_Click(object sender, EventArgs e)
        {
            Temperature value = Temperature.Medium;
            if (value == Temperature.Medium)
            {
                Console.WriteLine("Temperature is Mediuam..");
            }
        }

        static void Main(string[] args)
        {
            Temperature value = Temperature.Medium;
            int val = (int)value;
            Console.WriteLine("Temperature value is.." + val);
        }

        /*Retrieving enum values Ends*/




    }

}
