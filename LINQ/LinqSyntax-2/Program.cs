using System.Collections.Generic;
using System.Linq;

using static System.Console;

namespace LinqSyntax_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1  Obtain data-source
            IEnumerable<string> names = new string[] { "ram", "ramesh", "ramu", "raj", "raju" };

            // 2  define query
            // var result = new string[0];

            //var result = from name in names
            //             group name by name.Length;

            // 3  execute query
            //foreach (var studentGroup in result)
            //{
            //    WriteLine("length: " + studentGroup.Key);
            //    foreach (var student in studentGroup)
            //    {
            //        System.Console.WriteLine(student);
            //    }
            //    WriteLine("");
            //}

            // define query
            var result = from name in new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }
                         group name by name % 2 == 0;
            // execute query
            foreach (var studentGroup in result)
            {
                WriteLine(studentGroup.Key);
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
