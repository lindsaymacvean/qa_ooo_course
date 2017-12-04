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
            // then just return
            if (this.Contains(item.OfferID))
                return;
            else
                base.InsertItem(index, item);
        }
    }
}