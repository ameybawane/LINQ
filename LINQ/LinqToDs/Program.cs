using LinqToDs.Data_Source;

using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace LinqToDs
{
    class Program
    {
        static void Main(string[] args)
        {


           


            var productNames = from products in table.AsEnumerable()
                               
                               select products.Field<string>("ProductName");


            Console.WriteLine("Product Names: ");


            foreach (string productName in productNames)
            {
                Console.WriteLine(productName);
            }


            


            Console.ReadKey();

        }
    }
}
