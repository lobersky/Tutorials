using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745Li";
            myCar.Year = 2005;
            myCar.Colour = "Black";

            printVehicleDetails(myCar);

            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Colour = "Black";
            myTruck.TowingCapacity = 1200;
            printVehicleDetails(myTruck);

            Console.ReadLine();
        }

        // Set up method to call the class helper method to format information
        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the Vehicle's details: {0}",
                vehicle.FormatMe());
        }
    }

    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        // Helper method
        public abstract string FormatMe();
    }

    class Car : Vehicle
    {
        // Helper method
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Year,
                this.Colour);
        }
    }

    sealed class Truck : Vehicle
        // inherit key properties from the vehicle class and add a new property
        // seal it so nothing can inherit from it!
    {
        public int TowingCapacity { get; set; }

        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} Towing units", 
                this.Make,
                this.Model,
                this.TowingCapacity);
        }
    }
}