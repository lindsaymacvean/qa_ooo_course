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
        public void TestOffer()
        {
            Offer o1 = CreateOffer();
            Assert.AreEqual(321, o1.OfferID,
                "The Offer ID did not match");
            Assert.AreEqual("Test description", o1.OfferDescription,
                "The Offer Description did not match");
            Assert.AreEqual("Discount", o1.ShortDescription,
                "The Offer ShortDescription did not match");
            Assert.AreEqual(10, o1.DiscountPercentage,
                "The Discount Percentage did not match");
            Assert.AreEqual(0, o1.Quantity,
                "The Quantity did not match");
            Assert.AreEqual(2, o1.TFTPOTGroup,
                "The TFTPOTGroup did not match");
            List<int> l1 = new List<int>();
            Product p1 = ProductTests.CreateProduct();
            l1.Add(p1.ProductID);
            CollectionAssert.AreEqual(l1, o1.Products, "The Products did not match: {0}, {1}", String.Join(",", l1),
                String.Join(",", o1.Products));
        }

        public static Offer CreateOffer()
        {
            Offer o1 = new Offer();
            try
            {
                {
                    o1.OfferID = 321;
                    o1.OfferDescription = "Test description";
                    o1.ShortDescription = "Discount";
                    o1.DiscountPercentage = 10;
                    o1.Quantity = 0;
                    o1.TFTPOTGroup = 2;
                    Product p1 = ProductTests.CreateProduct();
                    int pID = p1.ProductID;
                    o1.Products.Add(pID);

                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return o1;
        }
    }
}
