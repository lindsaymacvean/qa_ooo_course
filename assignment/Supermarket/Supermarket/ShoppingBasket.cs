using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    // Using a KeyedCollection because it makes sense that the key is also a property of the object
    public class ShoppingBasket : KeyedCollection<int, BasketItem>
    {

        public ShoppingBasket()
        {
            this.OfferList = new OfferList();
        }
        // 
        public OfferList OfferList { set; get; }
        public OfferList OffersApplied
        {
            get
            {
                // Make a dictionary of currently available offers with the number of 
                // basketitems associated with each
                
                // For each offer in the list calculate if the offer is applicable
                this.TotalBeforeDiscount = 0;
                return this.OfferList;
            }
        }

        public decimal NumberItems
        {
            get
            {
                decimal i = 0;
                foreach (BasketItem item in Items)
                {
                    i = i + item.Quantity;
                }
                return i;
            }
        }

        // Question: should I have a private property to make this safer?
        public decimal TotalBeforeDiscount { get; set; }
        public decimal Total
        {
            get
            {
                decimal i = 0;
                foreach (BasketItem item in Items)
                {
                    i = i + item.TotalPrice;
                }
                return Math.Round(i, 2) - this.TotalBeforeDiscount;
            }
        }

        protected override int GetKeyForItem(BasketItem item)
        {
            return item.ProductID;
        }

        protected override void InsertItem(int index, BasketItem item)
        {
            // If the Keyed Collection already has the product
            // then just increment its quantity
            if (this.Contains(item.ProductID))
            {
                this[item.ProductID].Quantity += item.Quantity;
            }
            else
            {
                OfferList.Add(item.Offer);
                base.InsertItem(index, item);
            }
        }

        protected override void RemoveItem(int index)
        {
            BasketItem item = base.Items[index];
            item.Offer.Quantity -= item.Quantity;
            if (item.Offer.Quantity == 0)
                OfferList.Remove(item.Offer.OfferID);
            base.RemoveItem(index);
        }
    }
}
