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
        public int Quantity
        {
            get { return this.Quantity; }
            set
            {
                this.Quantity = value;
                this.Offer.Quantity += value;
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
