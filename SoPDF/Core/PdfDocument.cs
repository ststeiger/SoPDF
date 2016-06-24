namespace SoPDF.Core
{
    public class PdfDocument
    {
        public byte[] ID { get; set; } = new byte[16];

        public string Path { get; set; }

        public PdfHeader Header { get; set; }

        public PdfBody Body { get; set; }

        public PdfXREF XREF { get; set; }

        public PdfTrailer Trailer { get; set; }

        public PdfDocument()
        {
            Header = new PdfHeader();
        }

        //private void GenerateID()
        //{
        //    using (RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create())
        //    {
        //        randomNumberGenerator.GetBytes(ID);
        //    }
        //}
    }
}
