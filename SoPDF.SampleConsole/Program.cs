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
            Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");
            FileStream fileStream = new FileStream(Directory.GetCurrentDirectory() + "\\test.pdf", FileMode.Create, FileAccess.Write);
            BinaryWriter streamWriter = new BinaryWriter(fileStream);
        }
    }
}
