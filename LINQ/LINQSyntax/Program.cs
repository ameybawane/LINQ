using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace LINQSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 = obtain data-source
            IEnumerable<string> names = new string[] { "ram", "ramesh", "ramu" };

            // 2 = define query
            var result = endWithSelect(names);

            // 3 = execute query
            foreach (var name in result)
            {
                WriteLine(name);
            }
            ReadKey();

            IEnumerable<string> endWithSelect(IEnumerable<string> nameList)
            {
                return from name in nameList
                       select name.ToUpper();
            }
        }
    }
}
