using SoPDF.Core;
using System;
using System.Collections.Generic;

namespace SoPDF.Objects
{
    public class ArrayObject : PdfObject
    {
        //public List<PdfObject> Content { get; set; }

        public ArrayObject(List<PdfObject> content)
        {
            if (content == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                base.Content = content;
            }
        }

        public override byte[] ToBytes()
        {
            List<PdfObject> content = base.Content as List<PdfObject>;
            if (content.Count > 0)
            {
                List<byte> output = new List<byte>();

                foreach (PdfObject obj in content)
                {
                    output.AddRange(PdfWriter.PdfEncoding.GetBytes(" "));
                    output.AddRange(obj.ToBytes());
                }

                output.Remove(0);
                output.InsertRange(0, PdfWriter.PdfEncoding.GetBytes("["));
                output.AddRange(PdfWriter.PdfEncoding.GetBytes("]"));

                return output.ToArray();
            }
            else
            {
                return PdfWriter.PdfEncoding.GetBytes("[]");
            }
        }
    }
}
