using LINQ.Remote.DbModels;

namespace EnumerableVsQuerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            withEnumerable();
            withQuerable();

            Console.ReadKey();
        }
        static void withEnumerable()
        {
            IEnumerable<Employee> employees = new PMSContext().Employees;
            IEnumerable<Employee> foundEmployees = from emp in employees
                                                    where emp.DepartmentId == 1
                                                    select emp;
            foreach (var item in foundEmployees)
            {
            }
        }
        static void withQuerable()
        {
            IQueryable<Employee> employees = new PMSContext().Employees;
            IQueryable<Employee> foundEmployees = from emp in employees
                                                   where emp.DepartmentId == 1
                                                   select emp;
            foreach (var item in foundEmployees)
            {
            }
        }
    }
}