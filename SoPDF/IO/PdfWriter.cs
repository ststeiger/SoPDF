using System.IO;
using System.Text;

namespace SoPDF.IO
{
    internal class PdfWriter : BinaryWriter
    {
        internal static Encoding PdfEncoding { get; private set; }

        internal PdfWriter(string path, Encoding encoding) : base(new FileStream(path, FileMode.Create), encoding, false)
        {
            PdfEncoding = encoding;
        }

        internal void Write(IWritable writableObj)
        {
            base.Write(writableObj.ToBytes());
        }
    }
}