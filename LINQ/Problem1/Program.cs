using static System.Console;
namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string sen = "A penny saved is a penny earned.";
            //// Split the sentence into an array of words, split() function
            //string[] toWord = sen.Split();
            //var result = from word in toWord
            //             let Words = word.ToLower()
            //             // select word with first char with "p"
            //             where Words.StartsWith("p")
            //             select Words;
            //// execute query
            //foreach (var name in result)
            //{
            //    WriteLine(name);
            //}

            //string[] sens = new string[] { "A penny saved is a penny earned." };
            //var temp = from sen in sens
            //           let words = sen.Split()
            //           select words;
            //foreach (var item in temp)
            //{
            //    Console.WriteLine(item);
            //}

            string[] sens = new string[] { "A penny saved is a penny earned." };
            var temp = from sen in sens
                       let words = sen.Split()
                       from word in words
                       where word.StartsWith("p")
                       select word;
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }

            //var numbers = new int[] { 11, 45, 67, 89, 45 };
            //// filter record with where
            //var result = from number in numbers
            //             let temp = number + 33
            //             where temp > 100
            //             select temp;
            //// execute query
            //foreach (var item in result)
            //{
            //    WriteLine(item);
            //}

            ReadKey();
        }
    }
}