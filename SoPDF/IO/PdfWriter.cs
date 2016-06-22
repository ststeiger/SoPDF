using System.IO;
using System.Text;

namespace SoPDF.IO
{
    internal class PdfWriter : BinaryWriter
    {
        #region constructor

        internal PdfWriter(Stream output) : base(output) { }

        internal PdfWriter(Stream output, Encoding encoding) : base(output, encoding) { }

        internal PdfWriter(Stream output, Encoding encoding, bool leaveOpen) : base(output, encoding, leaveOpen) { }
        #endregion

        #region method
        #endregion
    }
}
