using SoPDF.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoPDF.SampleConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Tester();
            Console.WriteLine("Hello World");

            PdfDocument doc = new PdfDocument();
            PdfWriter writer = new PdfWriter(@"D:\test.pdf");
            writer.Write(doc);
            writer.Flush();
            writer.Dispose();
            Console.ReadKey();
        }

        public static void Tester()
        {
            string cureentDirectory = Directory.GetCurrentDirectory();
            FileStream fileStream = new FileStream(Directory.GetCurrentDirectory() + @"\test.pdf", FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fileStream.Length];
            fileStream.Read(buffer, 0, buffer.Length);

            for (int i = 0; i < buffer.Length; i++)
            {
                byte b = buffer[i];
                string output = Encoding.ASCII.GetString(new byte[1] { buffer[i] });
                //Console.WriteLine($"{buffer[i]}\t\t{Encoding.ASCII.GetString(new byte[1] { buffer[i] })}");
                Console.Write(Encoding.ASCII.GetString(new byte[1] { buffer[i] }));
                //Thread.Sleep(100);
            }

            string content = Encoding.ASCII.GetString(buffer);
            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\byte.txt", buffer);
            File.WriteAllText(Directory.GetCurrentDirectory() + @"\string.txt", content);
            //Console.WriteLine(content);
        }
    }
}
