using System.IO;
using System.Text;

namespace SoPDF.IO.Interfaces
{
    public interface IPdfElement
    {
        void Write(Stream output);

        void Write(Stream output, Encoding encoding);

        void Write(Stream output, Encoding encoding, bool leaveOpen);
    }
}
