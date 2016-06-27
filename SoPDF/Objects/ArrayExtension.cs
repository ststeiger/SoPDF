using SoPDF.Core;
using System;
using System.Collections.Generic;

namespace SoPDF.Objects
{
    public static class ArrayExtension
    {
        public static byte[] ToBytes(this PdfObject[] array)
        {
            if (array != null)
            {
                if (array.Length > 0)
                {
                    List<byte> output = new List<byte>();

                    output.AddRange(PdfWriter.PdfEncoding.GetBytes("["));
                    foreach (PdfObject obj in array)
                    {
                        if (obj != null)
                        {
                            output.AddRange(obj.ToBytes());
                            output.AddRange(PdfWriter.PdfEncoding.GetBytes(" "));
                        }
                    }
                    output.AddRange(PdfWriter.PdfEncoding.GetBytes("]"));

                    return output.ToArray();
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }

    //public class ArrayObject : PdfObject
    //{
    //    //public List<PdfObject> Content { get; set; }

    //    public ArrayObject(List<PdfObject> content)
    //    {
    //        if (content == null)
    //        {
    //            throw new NullReferenceException();
    //        }
    //        else
    //        {
    //            base.Content = content;
    //        }
    //    }

    //    public override byte[] ToBytes()
    //    {
    //        List<PdfObject> content = base.Content as List<PdfObject>;
    //        if (content.Count > 0)
    //        {
    //            List<byte> output = new List<byte>();

    //            foreach (PdfObject obj in content)
    //            {
    //                output.AddRange(PdfWriter.PdfEncoding.GetBytes(" "));
    //                output.AddRange(obj.ToBytes());
    //            }

    //            output.Remove(0);
    //            output.InsertRange(0, PdfWriter.PdfEncoding.GetBytes("["));
    //            output.AddRange(PdfWriter.PdfEncoding.GetBytes("]"));

    //            return output.ToArray();
    //        }
    //        else
    //        {
    //            return PdfWriter.PdfEncoding.GetBytes("[]");
    //        }
    //    }
    //}
}
