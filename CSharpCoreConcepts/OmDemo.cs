using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{


    public class IndividualBioData
    {
        private int _phoneNumber;

        internal string _name = string.Empty;

        internal string _description = string.Empty;

        public string _fatherName = string.Empty;

        public string _villageName = string.Empty;


        static void Main(string[] args)
        {
            IndividualBioData omBio = new IndividualBioData();

            omBio._fatherName = "Deepak Kumar";
            omBio._name = "Om Anand";

            Console.WriteLine( omBio._fatherName );

            IndividualBioData sampatBio = new IndividualBioData();
            sampatBio._fatherName = "M P Yadav";
            sampatBio._name = "Sampat";

            Console.WriteLine(sampatBio._fatherName);

            Console.WriteLine(sampatBio._name + omBio._name);
        }
    }





    public class OmDemo
    {
        private int _OMPhoneNumber;

        internal string _name = string.Empty;

        public string _description = string.Empty;

        public string _fatherName = string.Empty;

        public string _villageName = string.Empty;
        
        
        
        
        public void displayChachaName()
        {
            Console.WriteLine("SAMPAT KUMAR RAHUL");
        }

      
    

  
    
        static void Main(string[] args)
        {
            OmDemo demo = new OmDemo();
            demo.displayChachaName();
        }
    }
}
