using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is winding down the lane.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle virtual DriveVirtual method.");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Does the motorcycle have a sidecar? {HasSideCar}");
        }
        
    }
}
