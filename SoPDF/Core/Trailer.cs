using System;

namespace SoPDF.Core
{
    internal class Trailer : IWritable
    {
        public byte[] ToBytes(bool isReference = false)
        {
            return PdfWriter.PdfEncoding.GetBytes($"%%EOF");
        }
    }
}
