using SoPDF.Objects;
using System;

namespace SoPDF.Core
{
    internal class PdfBody : IWritable
    {
        private PdfDocumentCatalog DocumentCatalog { get; set; }

        internal PdfBody()
        {
            
        }

        private void InitialCatalog()
        {
            DocumentCatalog = new PdfDocumentCatalog(); 
        }

        public byte[] ToBytes(bool isReference = false)
        {
            throw new NotImplementedException();
        }
    }
}
