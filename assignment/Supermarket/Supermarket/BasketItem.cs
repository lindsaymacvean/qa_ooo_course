using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class BasketItem
    {
        public string Name { get; }
        public decimal UnitPrice { get; }
        // To stop a stackoverflow we need a private property
        private int _quantity;
        public int Quantity
        {
            get { return this._quantity; }
            set
            {
                this._quantity = value;
                // Update this items total if more units added
                this.CalculateTotal();
            }
        }

        public decimal TotalPrice { get; private set; }
        public int ProductID { get; }
        public Offer Offer { get; }
        public decimal DiscountAmount { get; set; }
        public string OfferDescription { get; }
        public string OfferShortDescription { get; }
        public int OfferID { get; }

        public BasketItem(Product product, int quantity)
        {
            // Setting the public properties
            this.Name = product.ProductName;
            this.UnitPrice = Math.Round(product.UnitPrice,2);
            this.ProductID = product.ProductID;
            this.Quantity = quantity;
            this.TotalPrice = product.UnitPrice * quantity;
            this.DiscountAmount = 0.00M;

            this.Offer = product.Offer;
            if (this.Offer != null)
            {
                this.OfferID = product.Offer.OfferID;
                this.Offer.Quantity += quantity;
                // These are only needed because the datagrid needs to map from here
                // I couldnt figure out how to map from the associated object
                this.OfferDescription = product.Offer.OfferDescription;
                this.OfferShortDescription = product.Offer.ShortDescription;
            }
        }

        private void CalculateTotal()
        {
            this.TotalPrice = this.Quantity * this.UnitPrice;
        }
    }
}
