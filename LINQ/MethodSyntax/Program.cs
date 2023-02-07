using System.Linq;

using static System.Console;


namespace MethodSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            // create query
            var methodSyntax = new string[3] { "apple", "mango", "orange" };

            // create query
            var querySyntax = methodSyntax.Select(x => x);

            WriteLine("Using Method Syntax:");

            foreach (var item in methodSyntax)
            {
                WriteLine(item);
            }
            ReadKey();
        }
    }
}
