using SoPDF.IO;
using System;
using System.Collections.Generic;
using System.IO;

namespace SoPDF.Objects
{
    public class StreamObject : PdfObject
    {
        public DictionaryObject Dictionary { get; set; }

        public StreamObject(DictionaryObject dictionary, Stream content)
        {
            if (dictionary == null || content == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                Dictionary = dictionary;
                base.Content = content;
            }
        }

        public override byte[] ToBytes()
        {
            List<byte> output = new List<byte>();
            output.AddRange(Dictionary.ToBytes());

            output.AddRange(PdfWriter.PdfEncoding.GetBytes("stream\n"));

            Stream content = base.Content as Stream;
            byte[] buffer = new byte[content.Length];
            content.Read(buffer, 0, buffer.Length);
            output.AddRange(buffer);

            output.AddRange(PdfWriter.PdfEncoding.GetBytes("endstream"));

            return output.ToArray();
        }
    }
}
