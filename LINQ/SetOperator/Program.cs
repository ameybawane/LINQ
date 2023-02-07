using LINQ.Remote.DbModels;
using SetOperator.Models;

namespace SetOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //withInMemoryExcept();
                //withInMemoryIntersect();
                //withInMemoryUnion();

                //withDatabaseExcept();
                //withDatabaseInnerJoin();

                //IEnumerable<EmployeeViewModel> result = withInnerJoin();
                //foreach (var n in result)
                //{
                //    Console.WriteLine(n.Name);
                //}

                //withLeftOuterJoin();
                deleteUseCase();
                deleteDepartmentUseCase();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        // Except Operator: The EXCEPT operator returns all distinct the rows that are
        // present in the result set of the first query, but not in the result set of the
        // second query. It means it returns the difference between the two result sets.
        static void withInMemoryExcept()
        {
            int[] numbersA = { 1, 3, 2, 4 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var uniqueNumbers = numbersA.Except(numbersB);
            Console.WriteLine("Common numbers from first array:");
            foreach(var n in uniqueNumbers)
            {
                Console.WriteLine(n);
            }
        }

        // Intersect Operator: The INTERSECT operator returns only the rows present in
        // all the result sets. The intersection of two queries gives the rows that are
        // present in both result sets. It returns only unique rows.
        static void withInMemoryIntersect()
        {
            int[] numbersA = { 1, 3, 2, 4 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var uniqueNumbers = numbersA.Intersect(numbersB);
            Console.WriteLine("Common numbers from both array:");
            foreach (var n in uniqueNumbers)
            {
                Console.WriteLine(n);
            }
        }

        // Union Operator: he UNION operator combines two or more result sets into a
        // single result set, without duplications. The union of two queries gives
        // rows that are present in the first result set or in the second result
        // set or in both. But each row appears only once.
        static void withInMemoryUnion()
        {
            int[] numbersA = { 1, 3, 2, 4 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var uniqueNumbers = numbersA.Union(numbersB);
            Console.WriteLine("Combines numbers from both array without duplication:");
            foreach (var n in uniqueNumbers)
            {
                Console.WriteLine(n);
            }
        }
        static void withDatabaseExcept()
        {
            using (var DbContext = new PMSContext())
            {
                var employees = (from p in DbContext.Employees
                                select p.DepartmentId);
                var departments = (from s in DbContext.Departments
                                select s.Id);

                IEnumerable<int> uniqueNumbers = departments.Except(employees);
                Console.WriteLine("Unique numbers from Client table:");
                foreach (var n in uniqueNumbers)
                {
                    Console.WriteLine(n);
                }
            }
        }
        static void withDatabaseInnerJoin()
        {
            using (var DbContext = new PMSContext())
            {
                var joinResult = from e in DbContext.Employees
                                 join d in DbContext.Departments
                                 on e.DepartmentId equals d.Id
                                 select new
                                 {
                                     e.FirstName,
                                     d.Name
                                 };
                Console.WriteLine("With Database Inner Join:");
                foreach (var n in joinResult)
                {
                    Console.WriteLine(n.Name + " " + n.FirstName);
                }
            }
        }
        static IEnumerable<EmployeeViewModel> withInnerJoin()
        {

            using (var DbContext = new PMSContext())
            {
                var dbModels = from e in DbContext.Employees
                               join d in DbContext.Departments
                               on e.DepartmentId equals d.Id
                               select new
                               {
                                   e.FirstName,
                                   e.LastName,
                                   d.Name,
                                   e.Email
                               };

                Console.WriteLine("Temp View Model:");
                ICollection<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();

                foreach (var dbModel in dbModels)
                {
                    employeeViewModels.Add(new EmployeeViewModel
                    {
                        Name = dbModel.FirstName + " " + dbModel.LastName,
                        Email = dbModel.Email
                    });
                }
                return employeeViewModels;
            }
        }
        static void withLeftOuterJoin()
        {

            using (var DbContext = new PMSContext())
            {
                var dbModels = from d in DbContext.Departments
                               join e in DbContext.Employees
                               on d.Id equals e.DepartmentId
                               into empDp
                               from ED in empDp.DefaultIfEmpty()
                               select new
                               {
                                   DepartmentName = d.Name,
                                   EmpName = ED.FirstName ?? "N/A"
                               };

                Console.WriteLine("Left join result:");
                var employeeViewModels = dbModels;

                foreach (var dbModel in dbModels)
                {
                    Console.WriteLine(dbModel.DepartmentName + " " + dbModel.EmpName);
                }
            }
        }

        // If IsActive =0 delete the department
        static void deleteUseCase()
        {
            using (var DbContext = new PMSContext())
            {
                var inActiveDepart = from dept in DbContext.Departments
                                     where dept.IsActive == false
                                     select dept;

                if (inActiveDepart.Any())
                {
                    foreach (Department department in inActiveDepart)
                    {
                        DbContext.Departments.Remove(department);
                        DbContext.SaveChanges();
                    }
                }
            }
        }

        // If IsActive =1 and there is no employee in that department then only
        // delete the department
        static void deleteDepartmentUseCase()
        {
            using (var DbContext = new PMSContext())
            {
                var inActiveDepart = getDepartmentByStatus(false);

                if (inActiveDepart.Any())  // InActive department
                {
                    foreach (Department department in inActiveDepart)
                    {
                        DbContext.Departments.Remove(department);
                    }
                    DbContext.SaveChanges();
                }

                // Active department, with no employees
                var activeDepart = getDepartmentByStatus(true);

                // find the employee count in each Active Department
                foreach (Department activeDept in activeDepart)
                {
                    int employeeCount = DbContext.Employees.Count(x => x.DepartmentId.Equals(activeDept.Id));
                    if (employeeCount == 0)
                    {
                        // delete department
                    }
                }
            }
        }
        static IQueryable<Department> getDepartmentByStatus(bool status)
        {
            var departments = from dept in new PMSContext().Departments
                              where dept.IsActive == status
                              select dept;
            return departments;
        }
    }
}