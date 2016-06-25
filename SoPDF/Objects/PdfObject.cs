using SoPDF.Core;

namespace SoPDF.Objects
{
    public abstract class PdfObject : IWritable
    {
        public bool IsIndirect { get; set; }

        public object Content { get; set; }

        public virtual byte[] ToBytes()
        {
            return PdfWriter.PdfEncoding.GetBytes(Content.ToString());
        }
    }
}
