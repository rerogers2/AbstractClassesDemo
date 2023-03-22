using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {

        public bool HasTrunk { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The car is driving down the road.");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Does the car have a trunk? {HasTrunk}");
        }
    }
}
