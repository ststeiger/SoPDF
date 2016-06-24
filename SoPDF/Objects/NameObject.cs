using System;
using System.Text;

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
            return Encoding.ASCII.GetBytes($"/{content.Replace("#", "#23")}");
        }
    }
}
