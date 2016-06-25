using System.IO;
using System.Text;

namespace SoPDF.IO
{
    internal class PdfWriter : BinaryWriter
    {
        internal PdfWriter(string path) : base(new FileStream(path, FileMode.Create), Encoding.ASCII, false) { }

        internal void Write(IWritable writableObj)
        {
            base.Write(writableObj.ToBytes());
        }
    }
}
