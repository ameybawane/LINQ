using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GettingStarted
{
    class Program
    {
        static void Main(string[] args)
        {

            const string folderPath = @"C:\windows";


          //  withoutLINQ(folderPath);

            Console.WriteLine();
            Console.WriteLine("============================");

            Console.WriteLine();

            withLINQ(folderPath);

            Console.WriteLine();

            Console.ReadKey();

        }


        #region WithoutLINQ
        private static void withoutLINQ(string path)
        {
        }
       
        #endregion





        #region withLINQ
        private static void withLINQ(string path)
        {
        }
        #endregion


        
    }
}
