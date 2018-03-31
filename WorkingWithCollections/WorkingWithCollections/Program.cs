using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Model = "Cutlas Supreme";
            car1.Make = "Oldsmobile";

            Car car2 = new Car();
            car2.Model = "Prism";
            car2.Make = "Geo";

            Book book1 = new Book();
            book1.Author = "Robert Taylor";
            book1.Title = "Microsoft .NET XML Web Services";
            book1.ISBN = "0-000-0000-0";
            
            // How to set up from generic collection - list
            List<Car> myList = new List<Car>();

            myList.Add(car1);
            myList.Add(car2);

            foreach (Car car in myList)
            {
                // Don't need to worry about casting!
                Console.WriteLine(car.Model);
            }
            
            // How to set up generic dictonary
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.Make, car1);
            myDictionary.Add(car2.Make, car2);

            Console.WriteLine(myDictionary["Geo"].Model);
            */

            // Defining and intialising in one step
            Car car1 = new Car() { Make = "Oldsmobile", Model = "Cultas Supreme" };
            Car car2 = new Car() { Make = "Geo", Model = "Prism" };
            Car car3 = new Car() { Make = "Nissan", Model = "Altima"};

            // Now with collections!
            List<Car> myList = new List<Car>() {
                new Car { Make = "Oldsmobile", Model = "Cultas Supreme" },
                new Car { Make = "Geo", Model = "Prism"},
                new Car { Make= "Nissan", Model = "Altima"}
            };

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
    }

    class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
    }
}
