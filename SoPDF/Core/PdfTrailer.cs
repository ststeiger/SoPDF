using System;
using System.IO;
using System.Text;
using SoPDF.IO.Interfaces;

namespace SoPDF.Core
{
    public class PdfTrailer : IElement
    {
        public void Write(Stream output)
        {
            throw new NotImplementedException();
        }

        public void Write(Stream output, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        public void Write(Stream output, Encoding encoding, bool leaveOpen)
        {
            throw new NotImplementedException();
        }
    }
}
