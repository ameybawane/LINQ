using static System.Console;
using System.Linq;
using System.Collections.Generic;
namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //var result = from num in numbers
            //              group num by num % 2;

            //foreach (var number in result)
            //{
            //    WriteLine(number.Key != 0 ? "Odd Numbers:" : "Even Numbers:");
            //    foreach (var i in number)
            //    {
            //        WriteLine(i);
            //    }
            //}

            // define query
            var result = from name in new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }
                         group name by name % 2 == 0;
            // execute query
            foreach (var studentGroup in result)
            {
                if (studentGroup.Key.Equals(false))
                {
                    WriteLine("Odd Numbers:");
                }
                else
                {
                    WriteLine("Even Numbers:");
                }

                foreach (var student in studentGroup)
                {
                    WriteLine(student);
                }
                WriteLine("");
            }
            ReadKey();
        }
    }
}