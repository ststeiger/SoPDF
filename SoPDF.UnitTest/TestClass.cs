using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoPDF.UnitTest
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void TestMethodPassing()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethodFailing()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void TestStringEqual()
        {
            var pdfName = "myPDF";
            Assert.AreEqual(pdfName, "myPDF");
        }

    }
}
