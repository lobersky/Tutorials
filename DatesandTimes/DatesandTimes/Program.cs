using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesandTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tutorial 14 - Working with Dates and Times
            // Get current date and time on pc
            // DateTime myValue = DateTime.Now;
            /*
            // Formatting Options:
            Console.WriteLine(myValue.ToString()); // print it, no fancy formatting
            Console.WriteLine(myValue.ToShortDateString()); // just the date
            Console.WriteLine(myValue.ToShortTimeString()); // just the time
            Console.WriteLine(myValue.ToLongDateString()); // date in words
            Console.WriteLine(myValue.ToLongTimeString()); // time with seconds
            */

            // Operations on DateTime
            // Addition
            // Console.WriteLine(myValue.AddDays(3).ToLongDateString()); // add 3 days and print new date in words
            // Console.WriteLine(myValue.AddHours(3).ToShortTimeString()); // add 3 hours and print new time
            // Subtraction
            // Console.WriteLine(myValue.AddDays(-3).ToShortDateString()); // subtract 3 days and print

            // Extract a particular component of DateTime
            // Console.WriteLine(myValue.Month.ToString());
            // Console.WriteLine(myValue.DayOfYear.ToString());

            // Create instance of new date with parsing integers
            // DateTime myBirthday = new DateTime(1969, 12, 7); 
            // Console.WriteLine(myBirthday.ToShortDateString());

            // Use TimeSpan object to compare two different DateTime objects
            DateTime myBirthday = DateTime.Parse("19/4/1990");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine(); 
        }
    }
}
