using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        // For example 1: 
        // private static string k = "";

        static void Main(string[] args)
        {
            // Example 2 - Accessibility Modifiers

            Car car = new Car();
            car.DoSomething();

            Console.ReadLine();

        }
    }
    /*
    // Example 1 - Scope and Variables
    static void Main(string[] args)
{
    string j = "";
    for (int i = 0; i < 10; i++)
    {
        j = i.ToString();
        k = i.ToString();
        Console.WriteLine(i);

        if (i == 9)
        {
            string l = i.ToString();
        }
    }
    Console.WriteLine("Outside of the for loop: " + j);
    // Console.WriteLine("k:" + k);
    helperMethod();
    Console.ReadLine();
}
static void helperMethod()
{
    Console.WriteLine("k from the helperMethod:" + k);
}
}
*/

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello World!";
        }
    }
}
