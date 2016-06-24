using SoPDF.Core;
using SoPDF.Objects;
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
        internal void Writer(PdfHeader header)
        {
            WriteComment("PDF-" + PdfHeader.Version);
            WriteComment(PdfHeader.BinaryComment);
        }

        internal void Write(ArrayObject arrayObj)
        {

        }

        internal void Write(BoolObject boolObj)
        {

        }

        internal void Write(DictionaryObject dictionaryObj)
        {

        }

        internal void Write(IntObject intObj)
        {

        }

        internal void Write(NameObject namObj)
        {

        }

        internal void Write(NumObject numObject)
        {

        }

        internal void Write(PdfObject pdfObj)
        {

        }

        internal void Write(RealObject realObj)
        {

        }

        internal void Write(StreamObject streamObj)
        {

        }

        internal void Write(StringObject stingObj)
        {

        }

        private void WriteComment(string s)
        {
            Write(Encoding.ASCII.GetBytes("%" + s + Environment.NewLine));
        }
        #endregion
    }
}
