using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoPDF.SampleConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tester();
            Console.ReadKey();
        }

        public static void Tester()
        {
            byte[] bytes = Encoding.UTF8.GetBytes("%PDF-1.7" + Environment.NewLine);
        }
    }
}
