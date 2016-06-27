using SoPDF.Objects;
using System;

namespace SoPDF.Core
{
    internal class PdfBody : IElement, IWritable
    {
        private PdfDocumentCatalog DocumentCatalog { get; set; }

        internal PdfBody()
        {

        }

        private void InitialCatalog()
        {
            DocumentCatalog = new PdfDocumentCatalog();
            DocumentCatalog.Add(new NameObject("Type"), new NameObject("Catalog"));
        }

        public byte[] ToBytes()
        {
            throw new NotImplementedException();
        }
    }
}
