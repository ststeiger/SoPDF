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

        internal void CreatePage()
        {
            PageTree pageTree = this["Pages"] as PageTree;

            Page page = new Page();
            
            ObjectWarehouse.GetWareHouse().Add(page);

            pageTree.Pages.Add(new Page());

        }
    }
}
