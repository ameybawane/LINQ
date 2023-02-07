using LinqToDs.Data_Source;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using static System.Console;

namespace LinqToDataTable
{
    class Program
    {
        static EmployeesRepository employeesRepository;

        static Program()
        {
            employeesRepository = new EmployeesRepository();
        }
        static void Main(string[] args)
        {
            try
            {
                DataTable dtEmployee = employeesRepository.GetAll();
                //IEnumerable<DataRow> query = null;
                //IEnumerable<DataRow> query = from emp in dtEmployee.AsEnumerable()
                //                             select emp;
                IEnumerable<DataRow> query = from emp in dtEmployee.AsEnumerable()
                                             where emp["Name"].ToString().Equals("ram")
                                             select emp;

                WriteLine("LINQ with dataTable");
                WriteLine("******************");

                foreach (DataRow p in query)
                {
                    WriteLine(p.Field<string>("Name"));
                    WriteLine(p[0].ToString());
                }
            }
            catch (Exception ex)
            {
                Exception runtimeError = ex.InnerException ?? ex;
                WriteLine(runtimeError.Message);
            }
            ReadKey();
        }
    }
}
