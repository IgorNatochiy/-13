using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building(32, 10, 5, 200);
            Console.WriteLine(building.Print());
            MultiBuilding multibuilding = new MultiBuilding(10, 50, 9, 300,  19);
            Console.WriteLine(multibuilding.Print());
            Console.ReadKey();
        }
    }
}
