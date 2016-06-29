using SoPDF.Objects;
using System.Collections.Generic;

namespace SoPDF.Core
{
    internal class PageTree : DictionaryObject
    {
        internal List<Page> Pages { get; set; }

        internal PageTree()
        {
            Pages = new List<Page>();
        }
    }
}
