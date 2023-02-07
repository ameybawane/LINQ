using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SortData
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                XElement xmlDoc = XElement.Load("EmployeeData.xml");


                IEnumerable<string> employees = null;

                foreach (string item in employees)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Exception runtimeError = ex.InnerException ?? ex;


                Console.WriteLine(runtimeError.Message);
            }



            Console.ReadKey();
        }
    }
}
