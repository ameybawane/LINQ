namespace FirstDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - obtain data source
            IEnumerable<string> numbers = new string[] { };
            var result = numbers.FirstOrDefault();
            Console.WriteLine(result);

            // defaultValue();

            Console.ReadKey();
        }

        static void defaultValue()
        {
            // 1 - obtain data source
            IEnumerable<int> numbers = new int[] { };
            var result = numbers.FirstOrDefault();
            Console.WriteLine(result);
        }
    }
}