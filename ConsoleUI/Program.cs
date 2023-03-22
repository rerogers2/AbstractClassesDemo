using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            var vehicles = new List<Vehicle>(); // List of Vehicle called vehicles
            //List<Vehicle> vehicles = new(); //does the same thing as the previous line

            // create 1 car, 1 motorcycle, 2 instances of type Vehicle w/ constructors from derived classes
            // set the properties with object initializer syntax
            var car1 = new Car() { HasTrunk = true, Year = "2005", Make = "Ford", Model = "Focus" };
            var motorcycle1 = new Motorcycle() { HasSideCar = false, Make = "Triumph", Model = "Thunderbird 900", Year = "2000" };
            Vehicle vehicle1 = new Car() { HasTrunk = false, Make = "Honda", Model = "CRV", Year = "2019" };
            Vehicle vehicle2 = new Motorcycle() { HasSideCar = true, Year = "2023", Make = "Ural", Model = "Sidecar" };

            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            Console.WriteLine("Our list of vehicles include:\n");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                vehicle.PrintInfo();
                Console.WriteLine();
            }
            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */
             
            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
