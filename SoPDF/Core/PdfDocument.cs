namespace SoPDF.Core
{
    public class PdfDocument
    {
        #region property
        public PdfHeader Header { get; set; }

        public PdfBody Body { get; set; }

        public PdfXREF XREF { get; set; }

        public PdfTrailer Trailer { get; set; }
        #endregion

        #region constructor
        public PdfDocument(string path)
        {
        }
        #endregion

        #region method
        //private void GenerateID()
        //{
        //    using (RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create())
        //    {
        //        randomNumberGenerator.GetBytes(ID);
        //    }
        //}
        #endregion
    }
}
