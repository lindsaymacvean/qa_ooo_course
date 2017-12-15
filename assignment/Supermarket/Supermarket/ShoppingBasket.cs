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

        public OfferList OfferList { set; get; }

        public decimal NumberItems
        {
            get
            {
                decimal i = 0;
                foreach (BasketItem item in Items)
                {
                    i += item.Quantity;
                }
                return i;
            }
        }

        public decimal TotalBeforeDiscount
        {
            get
            {
                decimal total = 0;
                foreach (BasketItem item in Items)
                {
                    total += item.Total;
                }
                return Math.Round(total, 2);
            }
        }

        public decimal TotalDiscount
        {
            get
            {
                decimal total = 0;
                foreach (BasketItem item in OfferList)
                {
                    total += item.Total;
                }
                return Math.Round(total, 2);
            }
        }

        public decimal Total
        {
            get
            {
                return this.TotalBeforeDiscount - this.TotalDiscount;
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
                OfferList.Add(item);
                OfferList.CalculateOffers(this);
            }
            else
            {
                base.InsertItem(index, item);
                OfferList.Add(item);
                OfferList.CalculateOffers(this);
            }
        }

        protected override void RemoveItem(int index)
        {
            BasketItem item = base.Items[index];
            if (item.Offer != null)
            {
                item.Offer.Quantity -= item.Quantity;
                OfferList.Remove(item);
            }

            base.RemoveItem(index);
        }
    }
}
