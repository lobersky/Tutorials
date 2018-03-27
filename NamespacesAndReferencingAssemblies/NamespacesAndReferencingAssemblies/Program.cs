using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabor;

namespace NamespacesAndReferencingAssemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.IO.StreamReader myStreamReader = new System.IO.StreamReader(); use full when ambigious classes case!
            // StreamReader myStreamReader = new StreamReader();

            // Bob created a library that can pull html info from website URL defined
            Bob bob = new Bob();
            string html = bob.Lookup("http://www.learnvisualstudio.net");
            Console.WriteLine(html);
            Console.ReadLine();
        }
    }
}
