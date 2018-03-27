using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Console.WriteLine("{0}", myCar.Make);

            Car myOtherCar = new Car("Ford", "Escape", 2005, "White");

            Console.WriteLine("{0} - {1} - {2} - {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Colour);

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public double OriginalPrice { get; set; }

        public Car()
        {
            // Load from config file later
            // Hardcode version that will automatically make any new instance of car have default make
            this.Make = "Nissan";
        }

        public Car(string make, string model, int year, string colour)
        {
            Make = make;
            Model = model;
            Year = year;
            Colour = colour;
        }

        // Introduction to the idea of static to create utility methods
        public static void myMethod()
        {
        }

        // Overloaded case will not work if name change only
        //public Car(string someOtherInputParameter, string model, int year, string colour)
        //{
        //    Make = someOtherInputParameter;
        //    Model = model;
        //    Year = year;
        //    Colour = colour;
        //}
    }
}
