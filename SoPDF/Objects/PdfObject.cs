using System.Text;

namespace SoPDF.Objects
{
    public abstract class PdfObject
    {
        public bool IsIndirect { get; set; }

        public object Content { get; set; }

        public virtual byte[] ToBytes()
        {
            return Encoding.ASCII.GetBytes(Content.ToString());
        }
    }
}
