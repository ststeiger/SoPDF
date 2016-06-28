using SoPDF.Core;

namespace SoPDF.Objects
{
    public class BoolObject : PdfObject
    {
        //private bool Content { get; set; }

        public BoolObject(bool content)
        {
            base.Content = content;
        }

        public override byte[] ToBytes(bool isReference = false)
        {
            bool content = bool.Parse(base.Content.ToString());
            return PdfWriter.PdfEncoding.GetBytes(content.ToString());
        }
    }
}
