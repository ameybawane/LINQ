using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace AdditionalClause
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 = obtain data-source
            IEnumerable<string> names = new string[] { "ram", "ramesh", "ramu" };

            // 2 = define query with where filter

            //var result = from name in names
            //             where name == "ram"
            //                    select name;

            var result = from name in names
                         where name.Length==3
                         select name;

            // 3 = execute query
            foreach (var name in result)
            {
                WriteLine("search operation output: " + name);
            }
            ReadKey();
        }
    }
}
