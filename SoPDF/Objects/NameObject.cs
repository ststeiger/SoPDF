using SoPDF.IO;
using System;

namespace SoPDF.Objects
{
    public class NameObject : PdfObject
    {
        //public string Content { get; set; }

        public NameObject(string content)
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
            return PdfWriter.PdfEncoding.GetBytes($"/{content.Replace("#", "#23")}");
        }
    }
}
