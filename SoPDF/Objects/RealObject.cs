using SoPDF.IO;

namespace SoPDF.Objects
{
    public class RealObject : NumObject
    {
        //private double Content { get; set; }

        public RealObject(double content)
        {
            base.Content = content;
        }

        public override byte[] ToBytes()
        {
            double content = double.Parse(base.Content.ToString());
            return PdfWriter.PdfEncoding.GetBytes(content.ToString());
        }
    }
}
