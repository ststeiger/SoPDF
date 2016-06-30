using System.Collections.Generic;

namespace SoPDF.Objects
{
    public class ObjectWarehouse
    {
        private static List<PdfObject> objects;
        private static object _lock = new object();

        private ObjectWarehouse()
        {

        }

        public static List<PdfObject> GetWareHouse()
        {
            if (objects == null)
            {
                lock (_lock)
                {
                    if (objects == null)
                    {
                        objects = new List<PdfObject>();
                    }
                }
            }

            return objects;
        }

        public byte[] ToBytes()
        {
            List<byte> output = new List<byte>();
            foreach (PdfObject item in objects)
            {
                output.AddRange(item.ToBytes());
            }

            return output.ToArray();
        }
    }
}