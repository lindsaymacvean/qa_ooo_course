using System.Collections.ObjectModel;

namespace Supermarket
{
    public class OfferList : KeyedCollection<int, Offer>
    {
        protected override int GetKeyForItem(Offer item)
        {
            return item.OfferID;
        }

        protected override void InsertItem(int index, Offer item)
        {
            // If the Keyed Collection already has the offer
            // then just increment its quantity
            if (this.Contains(item.OfferID))
                this[item.OfferID].Quantity += 1;
            else
                base.InsertItem(index, item);
        }

        protected override void RemoveItem(int index)
        {
            if (this[index].Quantity > 1)
                this[index].Quantity -= 1;
            else
                base.RemoveItem(index);
        }
    }
}