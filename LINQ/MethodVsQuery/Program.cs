using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace MethodVsQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            // define data-source
            string[] fruits = new string[3] { "apple", "mango", "orange" };

            // create query
            //var querySyntax = fruits;
            var querySyntax = from f in fruits
                              select f;

            WriteLine("Using Query Syntax:");
            printCollection(querySyntax);

            WriteLine();

            ReadKey();

            void printCollection(IEnumerable<string> linqSyntax)
            {
                foreach (var item in linqSyntax)
                {
                    WriteLine(item);
                }
            }
        }
    }
}
