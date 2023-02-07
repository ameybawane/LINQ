using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace XMLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                XElement xmlDoc = XElement.Load("EmployeeData.xml");


                loadAndPrintData(xmlDoc);


                IEnumerable<XElement> employees =
                                                from employee in xmlDoc.Descendants("Name")
                                                select employee;

                foreach (XElement item in employees)
                {
                    Console.WriteLine((string)item);
                }
            }
            catch (Exception ex)
            {
                Exception runtimeError = ex.InnerException ?? ex;


                Console.WriteLine(runtimeError.Message);
            }
           


            Console.ReadKey();

        }


        private static void loadAndPrintData(XElement xmlDoc)
        {
            XElement root = xmlDoc.Element("Employees");


            IEnumerable<XElement> employees = root.Elements();

            foreach (XElement employee in employees)
            {

                XElement empNameNode = employee.Element("Name");

                Console.WriteLine(empNameNode.Value);
            }

        }
    }


    
}
