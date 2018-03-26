using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tutorial 10 - Arrays

            // Example 4 - Built in Methods for Arrays
            string zig = "You can get what you want out of life" +
                "if you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar); // keep on the same line
            }
            Console.ReadLine();

            /*
             // Example 3 - With String Data Type
             string[] names = new string[] {"Eddie", "Alex", "Michael", "David Lee" };

             foreach(string name in names)
             {
                 Console.WriteLine(name);
             }
             Console.ReadLine();


             // Example 2
             // give list and let vstudio determine number of elements required
             int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 }; 

             Console.WriteLine(numbers[1].ToString());
             Console.ReadLine();

             // Example 1
             int[] numbers = new int[5];

             numbers[0] = 4;
             numbers[1] = 8;
             numbers[2] = 15;
             numbers[3] = 16;
             numbers[4] = 23;

             Console.WriteLine(numbers[1].ToString());
             Console.ReadLine();
             */
        }
    }
}
