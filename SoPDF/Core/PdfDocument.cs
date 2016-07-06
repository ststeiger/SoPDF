using System;
using System.Collections.Generic;
using System.Linq;
using SoPDF.Objects;

namespace SoPDF.Core
{
    public class PdfDocument : IWritable
    {
        public byte[] ID { get; set; } = new byte[16];

        public string Path { get; set; }

        private Header Header { get; set; }

        private Trailer Trailer { get; set; }

        public PdfDocument()
        {
            Header = new Header();
            Trailer = new Trailer();
        }

        public void CreatePage()
        {
            DocumentCatalog documentCatalog = ObjectWarehouse.GetWareHouse()[0] as DocumentCatalog;
            documentCatalog.CreatePage();
        }

        public byte[] ToBytes(bool isReference = false)
        {
            List<byte> output = new List<byte>();

            output.AddRange(Header.ToBytes().ToList());
            //output.AddRange(ObjectWarehouse.GetWareHouse().ToBytes().ToList());
            output.AddRange(Trailer.ToBytes().ToList());

            return output.ToArray();
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
