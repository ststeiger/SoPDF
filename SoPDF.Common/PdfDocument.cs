using SoPDF.Common.Enums;
using SoPDF.Common.Extensions;
using SoPDF.Common.Miscellaneous;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace SoPDF.Common
{
    public class PdfDocument : IDisposable
    {
        public readonly byte[] ID = new byte[16];

        public readonly double ScaleFactor;

        public readonly double Epsilon;

        public readonly Size Size;

        private List<PdfPage> pages;
        private List<PdfPage> Pages
        {
            get
            {
                if (pages == null)
                {
                    pages = new List<PdfPage>();
                }
                return pages;
            }
            set
            {
                pages = value;
            }
        }

        public int PageCount { get; set; }

        public PdfDocument()
        {
            GenerateID();
        }
        public PdfDocument(Stream documentStream, double width, double height, UnitEnum unit) : this()
        {
            ScaleFactor = unit.ToPoints();
            Epsilon = Constants.InchToPoint / (Constants.InchToEpsilon * ScaleFactor);
            Size = new Size(width, height);
        }

        public void AddPage(PdfPage pdfPage)
        {
            Pages.Add(pdfPage);
        }

        public void AddPages(IEnumerable<PdfPage> pdfPages)
        {
            Pages.AddRange(pdfPages);
        }

        public void RemovePage(PdfPage pdfPage)
        {
            Pages.Remove(pdfPage);
        }

        public void RemovePages(IEnumerable<PdfPage> pdfPages)
        {
            foreach (PdfPage pdfPage in pdfPages)
            {
                RemovePage(pdfPage);
            }
        }

        public void RemovePage(int PageNumber)
        {
            if (PageNumber >= 1 && PageNumber <= Pages.Count)
            {
                Pages.RemoveAt(PageNumber - 1);
            }
        }

        public void RemoveAllPages()
        {
            Pages.Clear();
        }

        public void Create()
        {
            Dispose();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        private void GenerateID()
        {
            using (RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create())
            {
                randomNumberGenerator.GetBytes(ID);
            }
        }
    }
}
