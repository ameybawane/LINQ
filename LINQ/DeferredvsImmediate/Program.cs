using System.Collections.Generic;
using System.Linq;

using static System.Console;

namespace DeferredvsImmediate
{
    class Program
    {
        static void Main(string[] args)
        {
            // define data-source
            ISet<string> dataSource = new HashSet<string>(3)
            {  "apple", "mango", "orange"  };

            // create query
            var deferredExecution = from fruit in dataSource
                                    select fruit;

            WriteLine("Deferred Execution.");
            //add new fruit;

            dataSource.Add("pineapple");

            printCollection(deferredExecution);
            ReadKey();

            void printCollection(IEnumerable<string> fruits)
            {
                foreach (var item in fruits)
                {
                    WriteLine(item);
                }
            }

        }

    }
}
