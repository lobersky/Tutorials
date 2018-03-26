using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tutorial 6 Variables and Data Types
            // Converting between Data Types Example 3 
            int x = 7;
            // string y = "Liz";
            string y = "5";
            // Convert data type int-to-str, concatenate and store
            string myFirstTry = x.ToString() + y;
          //  int mySecondTry = x + int.Parse(y);

            Console.WriteLine(myFirstTry);
          //  Console.WriteLine(mySecondTry);
            Console.ReadLine();

            /*
            // Integer Data Type Example 1 
            // Define variables x and y and integer type
            int x;
            int y;

            // Perform mathematical operation
            x = 7;
            y = x + 3;

            // Print result of y
            Console.WriteLine(y);
            Console.ReadLine();
            
            // String Data Type Example 2 
            string myFirstName = "Liz";
            Console.WriteLine(myFirstName);
            Console.ReadLine();
            // The power of var - detect data type, but must assign:
            // var myFirstName = "Liz";
             */
        }
    }
}
