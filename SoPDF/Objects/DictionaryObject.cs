using SoPDF.IO;
using System;
using System.Collections.Generic;

namespace SoPDF.Objects
{
    public class DictionaryObject : PdfObject
    {
        //public Dictionary<string, PdfObject> Content { get; set; }

        public DictionaryObject(Dictionary<string, PdfObject> content)
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
            Dictionary<string, PdfObject> content = base.Content as Dictionary<string, PdfObject>;

            if (content.Count > 0)
            {
                List<byte> output = new List<byte>();

                foreach (KeyValuePair<string, PdfObject> obj in content)
                {
                    output.AddRange(PdfWriter.PdfEncoding.GetBytes("   "));
                    output.AddRange(new NameObject(obj.Key).ToBytes());
                    output.AddRange(PdfWriter.PdfEncoding.GetBytes(" "));
                    output.AddRange(obj.Value.ToBytes());
                    output.AddRange(PdfWriter.PdfEncoding.GetBytes("\n"));
                }

                output.RemoveRange(0, 2);
                output.InsertRange(0, PdfWriter.PdfEncoding.GetBytes("<<"));
                output.AddRange(PdfWriter.PdfEncoding.GetBytes(">>"));

                return output.ToArray();
            }
            else
            {
                return PdfWriter.PdfEncoding.GetBytes("<<>>");
            }
        }
    }
}
