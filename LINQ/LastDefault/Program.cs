namespace LastDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // data source
            IEnumerable<int> numbers = null;
            numbers = new int[] { };
            numbers = numbers.DefaultIfEmpty();

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}