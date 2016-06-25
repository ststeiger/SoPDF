using SoPDF.Core;

namespace SoPDF.Objects
{
    public class IntObject : NumObject
    {
        //private int Content { get; set; }

        public IntObject(int content)
        {
            base.Content = content;
        }

        public override byte[] ToBytes()
        {
            int content = int.Parse(base.Content.ToString());
            return PdfWriter.PdfEncoding.GetBytes(content.ToString());
        }
    }
}
