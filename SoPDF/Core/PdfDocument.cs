namespace SoPDF.Core
{
    public class PdfDocument
    {
        public byte[] ID { get; set; } = new byte[16];

        public string Path { get; set; }

        private PdfHeader Header { get; set; }

        private PdfBody Body { get; set; }

        private PdfXREF XREF { get; set; }

        private PdfTrailer Trailer { get; set; }

        public PdfDocument()
        {
            Header = new PdfHeader();
            Body = new PdfBody();
            XREF = new PdfXREF();
            Trailer = new PdfTrailer();
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
