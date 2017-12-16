using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;

namespace Supermarket
{
    [TestClass]
    public class OfferTests
    {
        [TestMethod]
        public void OfferTest()
        {
            Offer o1 = CreateOffer();
            Assert.AreEqual(0, o1.Quantity,
                "The Quantity did not match");
            Assert.AreEqual(1, o1.OfferID,
                "The Offer ID did not match");
            Assert.AreEqual("Test description", o1.OfferDescription,
                "The Offer Description did not match");
            Assert.AreEqual("Discount", o1.ShortDescription,
                "The Offer ShortDescription did not match");
            Assert.AreEqual(null, o1.TFTPOTGroup,
               "The TFTPOTGroup did not match");
            Assert.AreEqual(10, o1.DiscountPercentage,
                "The Discount Percentage did not match");

            // This is just a product to test ProductID
            Product p1 = new Product()
            {
                ProductID = 2,
                OfferID = 1,
                ProductName = "test",
                UnitPrice = 10.00M,
                Offer = null
            };
            o1.Products.Add(p1.ProductID);
            List<int> l1 = new List<int> { 1, 2 };
            Assert.AreEqual(true, o1.Products.SetEquals(l1),
                "Products did not match");
            Assert.AreEqual("Test description", o1.ToString());
        }

        public static Offer CreateOffer()
        {
            Offer o1 = new Offer()
            {
                Quantity = -1,
                OfferID = 1,
                OfferDescription = "Test description",
                ShortDescription = "Discount",
                //TFTPOTGroup not currently used
                TFTPOTGroup = null,
                DiscountPercentage = 10,
                Products = { 1 }
            };
            return o1;
        }
    }
}
