using SoPDF.Core;
using SoPDF.Objects;
using System;
using System.IO;
using System.Text;

namespace SoPDF.IO
{
    internal class PdfWriter : BinaryWriter
    {
        internal PdfWriter(string path) : base(new FileStream(path, FileMode.Create), Encoding.UTF8, false) { }

        internal void Write(IWritable writableObj)
        {
            base.Write(writableObj.ToBytes());
        }

        //internal void Write(PdfHeader header)
        //{
        //    base.Write(header.ToBytes());
        //}

        //internal void Write(ArrayObject arrayObj)
        //{
        //    base.Write(arrayObj.ToBytes());
        //}

        //internal void Write(BoolObject boolObj)
        //{
        //    base.Write(boolObj.ToBytes());
        //}

        //internal void Write(DictionaryObject dictionaryObj)
        //{
        //    base.Write(dictionaryObj.ToBytes());
        //}

        //internal void Write(IntObject intObj)
        //{
        //    base.Write(intObj.ToBytes());
        //}

        //internal void Write(NameObject nameObj)
        //{
        //    base.Write(nameObj.ToBytes());
        //}

        //internal void Write(NumObject numObject)
        //{
        //    base.Write(numObject.ToBytes());
        //}

        //internal void Write(PdfObject pdfObj)
        //{
        //    base.Write(pdfObj.ToBytes());
        //}

        //internal void Write(RealObject realObj)
        //{
        //    base.Write(realObj.ToBytes());
        //}

        //internal void Write(StreamObject streamObj)
        //{
        //    base.Write(streamObj.ToBytes());
        //}

        //internal void Write(StringObject stringObj)
        //{
        //    base.Write(stringObj.ToBytes());
        //}
    }
}
