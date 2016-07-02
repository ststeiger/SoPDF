using SoPDF.Objects;

namespace SoPDF.Core
{
    internal class Page : DictionaryObject
    {
        public override byte[] ToBytes(bool isReference = false)
        {
            return PdfWriter.PdfEncoding.GetBytes(Content.ToString());
        }

    }
}
