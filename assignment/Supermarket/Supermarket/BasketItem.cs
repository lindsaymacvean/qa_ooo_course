using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class BasketItem
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public Offer Offer { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public BasketItem(Product product, decimal quantity, bool offer)
        {
            this.Name = product.ProductName;
            this.UnitPrice = Math.Round(product.UnitPrice,2);
            // this.Offer = product.Offer ?? new Offer();
            this.Quantity = quantity;
            this.TotalPrice = product.UnitPrice * quantity;
        }
    }
}
