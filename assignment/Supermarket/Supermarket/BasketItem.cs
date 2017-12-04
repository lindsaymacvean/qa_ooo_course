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

        public BasketItem(Product product, int quantity)
        {
            // Setting the public properties
            this.Name = product.ProductName;
            this.UnitPrice = Math.Round(product.UnitPrice,2);
            this.ProductID = product.ProductID;
            this.Quantity = quantity;
            this.Offer = product.Offer;
            this.Offer.Quantity += quantity;
            this.TotalPrice = product.UnitPrice * quantity;
        }

        private void CalculateTotal()
        {
            this.TotalPrice = this.Quantity * this.UnitPrice;
        }
    }
}
