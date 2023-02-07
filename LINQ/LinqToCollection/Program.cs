using Features;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

namespace LinqToCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // data-source
            IEnumerable<Employee> employees = new Employee[]
           {
                new Employee { Id = 1, Name= "ram",Age=34 },
                new Employee { Id = 2, Name= "mahesh",Age=31 },
                new Employee { Id = 2, Name= "raju",Age=13 },
                new Employee { Id = 2, Name= "paresh",Age=23 }
           };

            // define query

            // filter record with where
            var filterQuery = from employee in employees
                              where employee.Name.StartsWith("pa")
                              select employee;

            var projection = from employee in employees
                             select new { FirtsName = employee.Name, Age = employee.Age};
            // execute query
            foreach (var employee in projection)
            {
                WriteLine(employee.FirtsName);
            }

            WriteLine();
            WriteLine("LINQ with in-memory collection.");
            foreach (Employee employee in filterQuery)
            {
                WriteLine(employee.Name);
            }

            ReadKey();
        }
    }
}
