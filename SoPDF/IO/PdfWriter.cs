using SoPDF.Core;
using System;
using System.IO;
using System.Text;

namespace SoPDF.IO
{
    internal class PdfWriter : BinaryWriter
    {
        #region constructor
        internal PdfWriter(string path) : base(new FileStream(path, FileMode.Create), Encoding.UTF8, false) { }
        #endregion

        #region method
        internal void WriteHeader(PdfHeader header)
        {
            WriteComment("PDF-" + PdfHeader.Version);
            WriteComment(PdfHeader.BinaryComment);
        }

        private void WriteComment(string s)
        {
            Write(Encoding.UTF8.GetBytes("%" + s + Environment.NewLine));
        }
        #endregion
    }
}
