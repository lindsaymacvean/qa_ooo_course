using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Supermarket
{
    [TestClass]
    public class OfferTests
    {
        [TestMethod]
        public void TestOffer()
        {
            Offer o1 = Offer();
            Assert.AreEqual(321, o1.OfferID, 
                "The Offer ID did not match");
            Assert.AreEqual("Test description", o1.OfferDescription, 
                "The Offer Description did not match");
            Assert.AreEqual("Discount", o1.ShortDescription,
                "The Offer ShortDescription did not match");
            Assert.AreEqual(10, o1.DiscountPercentage,
                "The Discount Percentage did not match");
            Assert.AreEqual(1, o1.Quantity,
                "The Quantity did not match");
            Assert.AreEqual(2, o1.TFTPOTGroup,
                "The TFTPOTGroup did not match");
            //Not sure how to test a list
            //List<Product> l1 = new List<Product>();
            //l1.Add(ProductTests.CreateProduct());
            //CollectionAssert.AreEqual(l1, (ICollection<Product>)o1.Products,
            "The Products did not match");
        }


        public static Offer Offer()
        {
            Offer o1 = new Offer();
            try
            {
                {
                    o1.OfferID = 321;
                    o1.OfferDescription = "Test description";
                    o1.ShortDescription = "Discount";
                    o1.DiscountPercentage = 10;
                    o1.Quantity = 1;
                    o1.TFTPOTGroup = 2;
                    o1.Products = new List<Product>();
                    Product p1 = ProductTests.CreateProduct();
                    o1.Products.Add(p1);

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
