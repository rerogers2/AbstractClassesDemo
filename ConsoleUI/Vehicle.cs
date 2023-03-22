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

        public abstract void DriveAbstract(); // no implementation; no scope or body
        public virtual void DriveVirtual() // virtual with implementation 
        {
            Console.WriteLine("Something here for virtual DriveVirtual method.");
        }
    }
}
