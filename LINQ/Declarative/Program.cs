using static System.Console;
using System.Linq;
using System.Collections.Generic;

namespace Declarative
{
    class Program
    {
        // given the values, double the even numbers and total it.
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new int[5] { 1, 2, 3, 4, 5 };

            WriteLine("Without LINQ");
            int result = withoutLINQ(numbers);
            WriteLine("output: " + result);

            withLINQ(numbers);

            ReadKey();
        }

        private static int withoutLINQ(IEnumerable<int> numbers)
        {
            int result = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number * 2;
                }
            }
            return result;
        }

        static void withLINQ(IEnumerable<int> numbers)
        {
            WriteLine();
            WriteLine("With LINQ");

            var result = numbers.Where(x => x % 2 == 0)
                .Select(x => x * 2)
                .Sum();
            WriteLine("output: " + result);
        }
    }
}
