using System.Collections.Generic;
using System.Linq;

using static System.Console;

namespace ImmediateExecution
{
    class Program
    {
        static void Main(string[] args)
        {

            // define data-source

            IDictionary<int, string> dataSource = new Dictionary<int, string>(3)
            {
                [1] = "apple",
                [2] = "mango",
                [3] = "orange"
            };
            // create and execute query
            //var immediateExecution = (from fruit in dataSource
            //                          select fruit);
            var immediateExecution = (from fruit in dataSource
                                      select fruit).AsEnumerable();
            //var immediateExecution = (from fruit in dataSource
            //                          select fruit).ToList();
            dataSource.Add(4, "banana");

            WriteLine("Immediate Execution.");
            WriteLine("******************");
            foreach (var item in immediateExecution)
            {
                WriteLine(item.Value);
            }
            ReadKey();
        }
    }
}
