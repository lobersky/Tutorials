﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEnumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example of input enumerator inbuilt in Visual Studio
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Example of creating our own enumarator
            Console.WriteLine("Type in a superhero's name to see his nickname");
            string userValue = Console.ReadLine();

            SuperHero myValue;

            if (Enum.TryParse<SuperHero>(userValue, true, out myValue))
            {
                switch (myValue)
                {
                    case SuperHero.Batman:
                        Console.WriteLine("Caped Crusader");
                        break;

                    case SuperHero.Superman:
                        Console.WriteLine("Man of Steel");
                        break;

                    case SuperHero.GreenLantern:
                        Console.WriteLine("Emerald Knight");
                        break;
                    default:
                        break;
                }
            }

            else
            {
                Console.WriteLine("Does not compute");
            }

            Console.ReadLine();
        }
    }

    enum SuperHero
    {
        Batman,
        Superman,
        GreenLantern
    }
}