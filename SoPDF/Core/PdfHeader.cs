using SoPDF.IO;
using SoPDF.IO.Interfaces;
using System;
using System.Text;

namespace SoPDF.Core
{
    public class PdfHeader : IElement, IWritable
    {
        /// <summary>
        /// Mandatory: indicate PDF version
        /// </summary>
        public const double Version = 1.7;

        /// <summary>
        /// Optional: 
        /// inculde this comment to ensure proper behaviour of file transfer applications
        /// that inspect data near the beginning of a file
        /// to determine whether to treat the file’s contents as text or as binary 
        /// </summary>
        public const string BinaryComment = "????";

        public byte[] ToBytes()
        {
            return Encoding.ASCII.GetBytes($"%PDF-{Version}{Environment.NewLine}%{BinaryComment}{Environment.NewLine}");
        }
    }
}
