namespace SoPDF.Core
{
    internal class Header : IWritable
    {
        /// <summary>
        /// Mandatory: indicate PDF version
        /// </summary>
        private const double Version = 1.7;

        /// <summary>
        /// Optional: 
        /// inculde this comment to ensure proper behaviour of file transfer applications
        /// that inspect data near the beginning of a file
        /// to determine whether to treat the file's contents as text or as binary 
        /// </summary>
        private const string BinaryComment = "µµµµ";

        public byte[] ToBytes(bool isReference = false)
        {
            return PdfWriter.PdfEncoding.GetBytes($"%PDF-{Version}\n%{BinaryComment}\n");
        }
    }
}
