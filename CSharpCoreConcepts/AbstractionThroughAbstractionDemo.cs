using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoreConcepts
{
    /*using abstraction*/
    

    abstract class employeeLevelData
    {
        public abstract void Level_3();

    }

    abstract class adminLevelData : employeeLevelData
    {
        public abstract void Level_2();
    }

    abstract class managerLevelData : adminLevelData
    {
        public abstract void Level_1();
    }

    internal class AbstractionThroughAbstractionDemo : managerLevelData
    {
        
        public override void Level_1()
        {
            Console.WriteLine("This is level 1 data");
        }

        public override void Level_2()
        {
            Console.WriteLine("This is level 2 data");
        }

        public override void Level_3()
        {
            Console.WriteLine("This is level 3 data");
        }


        static void Main(string[] args)
        {
            string role = "Manager";
            if (role == "Manager")
            {
                managerLevelData managerdata = new AbstractionThroughAbstractionDemo();
                managerdata.Level_1();
                managerdata.Level_2();
                managerdata.Level_3();

                Console.WriteLine("Manager has access to all levels: level-1 level-2 and level-3");
                Console.ReadKey();
            }
            else if (role == "admin")
            {
                adminLevelData admindata = new AbstractionThroughAbstractionDemo();

                admindata.Level_2();
                admindata.Level_3();
                Console.WriteLine("Admin has access to level-2 and level-3");
                Console.ReadKey();
            }

            else if (role == "Employee")
            {
                employeeLevelData empdata = new AbstractionThroughAbstractionDemo();
                empdata.Level_3();
                Console.WriteLine("Employee has access to level-3 only");
                Console.ReadKey();
            }
        }


    }
}



    

