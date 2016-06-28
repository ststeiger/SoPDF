using SoPDF.Core;

namespace SoPDF.Objects
{
    public abstract class PdfObject : IWritable
    {
        public bool IsIndirect { get; set; }

        public object Content { get; set; }

        public string Position { get; set; }

        public virtual byte[] ToBytes(bool isReference = fasle)
        {
            return PdfWriter.PdfEncoding.GetBytes(Content.ToString());
        }
    }
}
