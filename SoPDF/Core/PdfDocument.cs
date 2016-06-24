using SoPDF.IO;
using System.IO;

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
        public PdfDocument()
        {
            Header = new PdfHeader();
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

        public void Write(string path)
        {
            PdfWriter pdfWriter = new PdfWriter(path);
            pdfWriter.Writer(Header);
        }
        #endregion
    }
}
