using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace Supermarket
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ProductTest()
        {
            Product p1 = CreateProduct();
            Assert.AreEqual(1, p1.OfferID, 
                "The Offer ID did not match");
            Assert.AreEqual(2, p1.ProductID, 
                "The ProductID did not match");
            Assert.AreEqual("test", p1.ProductName,
                "The Product Name did not match");
            Assert.AreEqual(10.00M, p1.UnitPrice,
                "The Unit Price did not match");
        }

        public static Product CreateProduct()
        {
            Product p1 = new Product();
            try
            {
                p1.OfferID = 1;
                p1.ProductID = 2;
                p1.ProductName = "test";
                p1.UnitPrice = 10.00M;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return p1;
        }
    }
}
