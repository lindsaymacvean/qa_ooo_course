using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Collections.Generic;
using ExpectedObjects;

namespace Supermarket
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ProductTest()
        {
            Product p1 = CreateProduct();
            Assert.AreEqual(2, p1.ProductID,
                "The ProductID did not match");
            Assert.AreEqual(1, p1.OfferID,
                "The Offer ID did not match");
            Assert.AreEqual("test", p1.ProductName,
                "The Product Name did not match");
            Assert.AreEqual(10.00M, p1.UnitPrice,
                "The Unit Price did not match");
            var expectedOffer = new Offer()
            {
                Quantity = -1,
                OfferID = 1,
                OfferDescription = "test description",
                ShortDescription = "test short description",
                TFTPOTGroup = null,
                DiscountPercentage = 10,
                Products = new List<int> { 1, 2, 3 },
            }.ToExpectedObject();
            expectedOffer.ShouldEqual(p1.Offer);
            Assert.AreEqual("test", p1.ToString());
        }

        public static Product CreateProduct()
        {
            Product p1 = new Product()
            {
                ProductID = 2,
                ProductName = "test",
                // This OfferID should probably be enforced to 
                // be consistent with the Offer
                OfferID = 1,
                UnitPrice = 10.00M,
                Offer = new Offer()
                {
                    Quantity = -1,
                    OfferID = 1,
                    OfferDescription = "test description",
                    ShortDescription = "test short description",
                    TFTPOTGroup = null,
                    DiscountPercentage = 10,
                    Products = new List<int> { 1, 2, 3 },
                }
            };
            return p1;
        }
    }
}
