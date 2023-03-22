using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "default";
        public string Make { get; set; } = "default";
        public string Model { get; set; } = "default";

        // this will need to be "override" in each class to have a specific output per class
        public abstract void DriveAbstract(); // no implementation; no scope or body

        // this is the default output for DriveVirtual and needs to be "override" in each class to change it
        public virtual void DriveVirtual() // virtual with implementation 
        {
            Console.WriteLine("Default virtual DriveVirtual method.");
        }

        // this will need to be "override" in each class to have a specific output per class
        public abstract void PrintInfo();
    }
}
