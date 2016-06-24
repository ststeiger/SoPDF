using SoPDF.IO.Interfaces;

namespace SoPDF.Core
{
    public class PdfHeader : IElement
    {
        /// <summary>
        /// Mandatory: indicate PDF version
        /// </summary>
        public const string Version = "1.7";

        /// <summary>
        /// Optional: 
        /// inculde this comment to ensure proper behaviour of file transfer applications
        /// that inspect data near the beginning of a file
        /// to determine whether to treat the file’s contents as text or as binary 
        /// </summary>
        public const string BinaryComment = "©©©©";

        public void Write()
        {

        }
    }
}
