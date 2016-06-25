using System;
using SoPDF.Objects;

namespace SoPDF.Core
{
    public class PdfBody : IElement, IWritable
    {
        public DictionaryObject Content { get; set; }
        
        public PdfBody()
        {
            
        }

        byte[] IWritable.ToBytes()
        {
            throw new NotImplementedException();
        }
    }
}
