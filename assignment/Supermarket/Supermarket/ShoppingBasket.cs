using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class ShoppingBasket
    {
        public List<BasketItem> Items { get; set; }
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
        public decimal Total
        {
            get
            {
                decimal i = 0;
                foreach (BasketItem item in Items)
                {
                    i = i + item.TotalPrice;
                }
                return Math.Round(i, 2);
            }
        }

        public ShoppingBasket()
        {
            // Apparently List properties have to be instantiated in the constructor
            this.Items = new List<BasketItem>();
        }

    }
}
