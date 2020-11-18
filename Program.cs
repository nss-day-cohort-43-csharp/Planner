using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("City Planner");

            Building myBuilding = new Building("123 Some St");
            myBuilding.Depth = 100.1;
            myBuilding.Width = 7.3;
            myBuilding.Stories = 89;

            myBuilding.Construct();
            myBuilding.Purchase("Groucho Marx");

            /*
            string myBuildingInfo = myBuilding.BuildingInfo();
            Console.WriteLine(myBuildingInfo);
            */

            Console.WriteLine(myBuilding);
        }
    }
}