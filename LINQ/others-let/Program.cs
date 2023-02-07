using Features;
using static System.Console;
using System.Linq;
using System.Collections.Generic;
namespace others_let
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // data-source
            IEnumerable<Employee> employees = new Employee[]
            {
                new Employee { Id = 1, Name = "ram", Age = 34 },
                new Employee { Id = 2, Name = "MahesH", Age = 31 },
                new Employee { Id = 3, Name = "raju", Age = 13 },
                new Employee { Id = 4, Name = "paresh", Age = 23 },
                new Employee { Id = 51, Name = "NaResh", Age = 34 },
                new Employee { Id = 61, Name = "dev", Age = 31 },
                new Employee { Id = 71, Name = "raj", Age = 13 },
                new Employee { Id = 81, Name = "sam", Age = 23 },
                new Employee { Id = 82, Name = "Suresh", Age = 23 }
            };

            //WriteLine("Pattern matching (StartsWith, EndsWith, Contains):");
            //// filter record with where
            //var filterQuery = from employee in employees
            //                  where employee.Name.StartsWith("pa")
            //                  select employee;
            //// execute query
            //foreach (Employee employee in filterQuery)
            //{
            //    WriteLine(employee.Name);
            //}



            //WriteLine("Using alias:");
            //// filter record
            //var projection = from employee in employees
            //                 select new { FirtsName = employee.Name, Age = employee.Age };
            //// execute query
            //foreach (var employee in projection)
            //{
            //    WriteLine("Name: " + employee.FirtsName);
            //    WriteLine("Age: " + employee.Age);
            //}



            //WriteLine("Using descending:");
            //// filter record
            //var orderByResult = from employee in employees
            //                    orderby employee.Name descending
            //                    select employee;
            //// execute query
            //foreach (var item in orderByResult)
            //{
            //    WriteLine(item.Name);
            //}



            //WriteLine("Using ToLower:");
            //// filter record
            //var toLower = from employee in employees
            //              where employee.Name.Equals(employee.Name.ToLower())
            //              select employee;
            //// execute query
            //foreach (var item in toLower)
            //{
            //    WriteLine(item.Name);
            //}


            //WriteLine("Using let:");
            //// filter record
            //var query = from employee in employees
            //            let name = employee.Name.Length
            //            where name > 3
            //            select employee;
            //// execute query
            //foreach (var item in query)
            //{
            //    WriteLine(item.Name);
            //}


            //WriteLine("Using orderby descending, multiple where condition:");
            //// filter record
            //var query = from employee in employees
            //            where employee.Id >= 50 && employee.Name.Length >= 3
            //            orderby employee.Name descending
            //            select employee;
            //// execute query
            //foreach (var item in query)
            //{
            //    WriteLine(item.Name);
            //}


            WriteLine("Using from, let, where, select:");
            // data-source
            var numbers = new int[] { 11, 45, 67, 89, 45, 86 };
            // filter record
            // add 33 in each number
            // select number which is greater than 100
            var query = from number in numbers
                        let temp = number + 33
                        where temp > 100
                        select temp;
            // execute query
            foreach (var item in query)
            {
                WriteLine(item);
            }
            ReadKey();
        }
    }
}