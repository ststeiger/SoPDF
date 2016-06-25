using SoPDF.Core;
using System;

namespace SoPDF.Objects
{
    public class StringObject : PdfObject
    {
        //public string Content { get; set; }

        public StringObject(string content)
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
            string content = base.Content.ToString();
            return PdfWriter.PdfEncoding.GetBytes($"({content})");
        }
    }
}
