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

        public byte[] ToBytes()
        {
            throw new NotImplementedException();
        }
    }
}
