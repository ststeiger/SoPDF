using SoPDF.Objects;
using System.Collections.Generic;

namespace SoPDF.Core
{
    internal class PdfDocumentCatalog : DictionaryObject
    {
        private PdfPageTree PageTree { get; set; }

        internal PdfDocumentCatalog()
        {
            this[new NameObject("Type")] = new NameObject("Catalog");
            PageTree = new PdfPageTree();
            this[new NameObject("Pages")] = PageTree;
        }
    }
}
