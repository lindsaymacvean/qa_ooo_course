using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Supermarket;
using System.Collections.Generic;
using ExpectedObjects;

namespace SupermarketTests
{
    [TestClass]
    public class ShoppingBasketItemTests
    {
        [TestMethod]
        public void BasketItemTest()
        {
            Product p1 = ProductTests.CreateProduct();
            var expectedBasketItem = new BasketItem(p1, 1)
                .ToExpectedObject();

            BasketItem b1 = CreateBasketItem();
            Assert.AreEqual("test", b1.ProductName,
                "Basketitem Name is not correct");
            Assert.AreEqual(10.00M, Math.Round(b1.LatestPrice, 2), 
                "Unit Price is not the same");
            Assert.AreEqual(2, b1.ProductID,
                "Product Id is not correct");
            Assert.AreEqual(1, b1.Quantity,
                "Quantity is not correct");
            Assert.AreEqual(10.00M, b1.TotalItemValue);
            // Because discounts are applied across multiple items
            // It does not make sense to test this property here
            // Instead it should be tested in an integration test
            //Assert.AreEqual(0.1, b1.DiscountAmount);
            expectedBasketItem.ShouldEqual(b1);
            Assert.AreEqual(1, b1.OfferID);
            Assert.AreEqual(1, b1.Offer.Quantity);
            Assert.AreEqual(10, b1.DiscountPercentage);
            Assert.AreEqual("test description", b1.OfferDescription);
            Assert.AreEqual("test short description", b1.OfferShortDescription);


            //Test when Offer is null
            //BasketItem b2 = new BasketItem()
            //Assert.AreEqual();

        }

        public static BasketItem CreateBasketItem()
        {
            Product p1 = ProductTests.CreateProduct();
            BasketItem b1 = new BasketItem(p1, 1);
            return b1;
        }
    }
}
