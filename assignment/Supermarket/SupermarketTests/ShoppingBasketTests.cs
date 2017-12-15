using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Supermarket
{
    [TestClass]
    public class ShoppingBasketTests
    {
        [TestMethod]
        public void ShoppingBasketTest()
        {
            // Create a product item, offer, and add them to a basket item

            // Add first product
            Product p1 = ProductTests.CreateProduct();

            // Create a corresponding offer for the product
            Offer o1 = new Offer
            {
                OfferID = 321,
                OfferDescription = "Test description",
                ShortDescription = "Discount",
                DiscountPercentage = 10
            };

            List<Offer> ol = new List<Offer>
            {
                o1
            };

            // Add the offer to the product
            p1.Offer = o1;

            // Create a basket item 
            BasketItem item1 = new BasketItem(p1, 2);


            // Create the actual basket and add the item to it
            ShoppingBasket basket = new ShoppingBasket
            {
                item1
            };

            Decimal total = basket.Total;
            // https://msdn.microsoft.com/en-us/library/ms243456.aspx
            //Assert.AreEqual(expected, total, 0.001, "Failure message");




            /* Adding one item for each type of offer

            adding one item without offer
            adding one item with each of the offers(tests 10 % off)
adding two items of each offer(tests bogof)
test two of the same or two different
adding three items of each offer(tests tftpot)
test all same, two same, or three different

    */
        }
    }
}
