using SoPDF.Objects;
using System.Collections.Generic;

namespace SoPDF.Core
{
    internal class DocumentCatalog : DictionaryObject
    {
        internal DocumentCatalog()
        {
            Initialize();
        }

        private void Initialize()
        {
            this["Type"] = new NameObject("Catalog");
            this["Pages"] = new PageTree();
        }

        internal void AddPage()
        {
            PageTree pageTree = this["Pages"] as PageTree;
            pageTree.Pages.Add(new Page());
        }
    }
}
