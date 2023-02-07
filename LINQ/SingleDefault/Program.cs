namespace SingleDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - obtain data source
            IEnumerable<string> names = new string[] { };

            singleMethod();
            //nonEmpty();

            Console.ReadKey();
        }

        static void nonEmpty()
        {
            // 1 - obtain data source
            IEnumerable<int> numbers = new int[] { 1, 2, 3, 1 };
            var result = numbers.Single();

            //IEnumerable<int> numbers = new int[] { 2, 3, 1, 1 };
            //var result = numbers.Single(x => x== 5);
            //var result = numbers.SingleOrDefault(x => x == 5);

            Console.WriteLine(result);
        }

        static void singleMethod()
        {
            IEnumerable<int> names = new int[] { 2, 4, 5, 7, 9 };
            // IEnumerable<int> names = new int[] { 21, 45, 5, 7, 9, 6 };
            var result = names.Single(x => x % 2 == 0);
            // Sequence contains more than one matching element
            // for 2 its 0
            // for 4 its 0
            Console.WriteLine(result);
        }
    }
}