namespace SoPDF.Core
{
    interface IWritable
    {
        byte[] ToBytes(bool isReference = false);
    }
}
