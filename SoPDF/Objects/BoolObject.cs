using System;
using System.Text;

namespace SoPDF.Objects
{
    public class BoolObject : PdfObject
    {
        //private bool Content { get; set; }

        public BoolObject(bool content)
        {
            base.Content = content;
        }

        public override byte[] ToBytes()
        {
            bool content = bool.Parse(base.Content.ToString());
            return Encoding.ASCII.GetBytes(content.ToString());
        }
    }
}
