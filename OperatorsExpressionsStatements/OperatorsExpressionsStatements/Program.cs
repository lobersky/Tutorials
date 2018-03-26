using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tutorial 8 - OperatorsExpressionsStatements
            int x, y, a, b; // declared multiple varaibles

            // Assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // Mathematical operators
            // Addition
            x = 3 + 4;
            // Subtraction
            x = 4 - 3;
            // Multiplication
            x = 10 * 5;
            // Division
            x = 10 / 5;

            // Operators to evaluate values
            // Equality
            if (x ==y)
            {
            }
            // Greater than
            if (x > y)
            {
            }
            // Less than
            if (x < y)
            {
            }
            // Greater than or equal to
            if (x >= y)
            {
            }
            // Less than or equal to
            if (x <= y)
            {
            }
            // Conditional operators
            // AND
            if ((x > y) && (a > b))
            {
            }
            // OR
            if ((x > y) || (a > b))
            {
            }
            // In-line conditional operator
            string message = (x == 1) ? "Car" : "Boat";

            // Member access and method invocation
            Console.WriteLine("Hi");
        }
    }
}
