using SoPDF.Core;
using System;
using System.Collections.Generic;

namespace SoPDF.Objects
{
    //public static class ArrayExtension
    //{
    //    public static byte[] ToBytes(this PdfObject[] array)
    //    {
    //        if (array != null)
    //        {
    //            if (array.Length > 0)
    //            {
    //                List<byte> output = new List<byte>();

    //                output.AddRange(PdfWriter.PdfEncoding.GetBytes("["));
    //                foreach (PdfObject obj in array)
    //                {
    //                    if (obj != null)
    //                    {
    //                        output.AddRange(obj.ToBytes());
    //                        output.AddRange(PdfWriter.PdfEncoding.GetBytes(" "));
    //                    }
    //                }
    //                output.AddRange(PdfWriter.PdfEncoding.GetBytes("]"));

    //                return output.ToArray();
    //            }
    //            else
    //            {
    //                throw new IndexOutOfRangeException();
    //            }
    //        }
    //        else
    //        {
    //            throw new NullReferenceException();
    //        }
    //    }
    //}

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
            if (base.Content != null)
            {
                if ((base.Content as List<PdfObject>).Count > 0)
                {
                    List<byte> output = new List<byte>();

                    output.AddRange(PdfWriter.PdfEncoding.GetBytes("["));
                    foreach (PdfObject obj in (base.Content as List<PdfObject>))
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
}
