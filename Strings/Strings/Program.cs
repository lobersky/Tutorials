using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 9 - Other String Manipulations

            string myString = "That summer we took threes across the board   ";
            // myString = myString.Substring(5,14); // will retrieve at position range specified (includes spaces!)

            // myString = myString.ToUpper(); // format to uppercase

            // myString = myString.Replace(" ", "--"); // replace spaces with -- (good for massaging data formats)

            myString = string.Format(
                "Length before: {0} -- After: {1}", 
                myString.Length, 
                myString.Trim().Length);

            Console.WriteLine(myString);
            Console.ReadLine();

            /*
            // Example 8 - String Concatenation using in built class StringBuilder
            // This approach is more efficient and was built to manage length change issues
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
            
            // Example 7 - Basic String concatenation
            string myString = "";

            for (int i = 0; i < 100; i++)
            {
                myString = myString + "--" + i.ToString(); // basic concatenation
                myString += "--" + i.ToString(); // shorter form but can have memory and speed issues due to length changes!
            }

            Console.WriteLine(myString);
            Console.ReadLine();

            // Example 6 - Format number outputs
            // :C for dollar sign with language preferences on pc
            string myString = string.Format("{0:C}", 123.45); 

            // :N for commas and decimal places
            string myString = string.Format("{0:N}", 123456789);

            // :P for percentages
            string myString = string.Format("{0:P}",0.123);

            // Specify format with # for phone numbers
            string myString = string.Format("Phone number: {0:(###) ###-####}", 1234567890);

            Console.WriteLine(myString);
            Console.ReadLine();

            // Example 5 - Two Substituions 
            string myString = string.Format("Make: {0} (Model:{1})", "BMW", "760li");

            Console.WriteLine(myString);
            Console.ReadLine();

            // Example 4 - Simple String Substitution
            string myString = string.Format("{0}!", "Bonzai"); // 0 reference is the insert point for the bonzai input

            Console.WriteLine(myString);
            Console.ReadLine();
            
            // Example 3 - String with new line display
            // For full list of characer escape sequences see:
            // https://blogs.msdn.microsoft.com/csharpfaq/2004/03/12/what-character-escape-sequences-are-available/ 
            string myString = "What if I need \n a new line?";

            Console.WriteLine(myString);
            Console.ReadLine();

           // Example 2 - String with quotation marks
           string myString = "My \"so called\" life";

           Console.WriteLine(myString);
           Console.ReadLine();

           // Example 1  - String with backslash 
           string myString = "Go to your c:\\ drive";

           Console.WriteLine(myString);
           Console.ReadLine(); 
           */

        }
    }
}
