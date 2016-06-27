using SoPDF.Objects;
using System.Collections.Generic;

namespace SoPDF.Core
{
    internal class PdfDocumentCatalog : DictionaryObject
    {
        private List<PdfPage> PageTree { get; set; }
    }
}
