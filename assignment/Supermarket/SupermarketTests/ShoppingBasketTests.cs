using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ExpectedObjects;

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

            // Create a basket item 
            BasketItem item1 = new BasketItem(p1, 2);

            // Create the actual basket and add the item to it
            //ShoppingBasket basket = new ShoppingBasket();
            //basket.Add(item1);

            ////basket check
            //var expectedBasket = new ShoppingBasket()
            //{

            //}.ToExpectedObject();
            //expectedBasket.ShouldEqual(basket);

            ////OfferList
            //var expectedOfferList = new OfferList()
            //{

            //}.ToExpectedObject();
            //expectedOfferList.ShouldEqual(basket.OfferList);

            ////NumberOfItems


            ////TotalBeforeDiscount

            ////TotalDiscount

            ////BasketTotal

            ////Remove()

            ////Clear


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
