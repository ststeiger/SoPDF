using System.IO;
using System.Text;

namespace SoPDF.Core
{
    public class PdfWriter : BinaryWriter
    {
        internal static Encoding PdfEncoding { get; } = Encoding.ASCII;

        public PdfWriter(string path) : base(new FileStream(path, FileMode.Create), PdfEncoding, false)
        {

        }

        internal void Write(IWritable writableObj)
        {
            base.Write(writableObj.ToBytes());
        }

        public void Write(PdfDocument pdfDocument)
        {
            base.Write(pdfDocument.ToBytes());
        }
    }
}