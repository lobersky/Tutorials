using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new instance of car
            Car myNewCar = new Car();
            
            // Set properties
            myNewCar.Make = "Mazda";
            myNewCar.Model = "3";
            myNewCar.Year = 2010;
            myNewCar.Colour = "Blue";
            
            // Get properties
            Console.WriteLine("{0} - {1} - {2} - {3}", 
                myNewCar.Make, 
                myNewCar.Model, 
                myNewCar.Year, 
                myNewCar.Colour);
            // Helper method case:
            // double marketValueOfCar = determineMarketValue(myNewCar); 

            // Member method case: 
            Console.WriteLine("Car's value: {0:C}", myNewCar.DetermineMarketValue());

            Console.ReadLine();
        }
        //// Helper method
        //private static double determineMarketValue(Car car)
        //{
        //    double carValue = 100.0;
            
        //    // Go online and look up car's value and retrieve it's value into carValue variable.

        //    return carValue;
        //}
    }

    class Car
    {
        // Define properties of Car class
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        // Class method(member method)

        public double DetermineMarketValue()
        {
            double carValue = 100.0;

            if (this.Year > 1990)
            {
                carValue = 10000.0;
            }
            else
            {
                carValue = 2000.0;
            }
            return carValue;
        }
    }
}
