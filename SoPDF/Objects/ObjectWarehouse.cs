using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
