namespace Supermarket
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Offer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Offer()
        {
            Products = new List<int>();
            Quantity = 0;
        }

        [NotMapped]
        private int _quantity;
        [NotMapped]
        public int Quantity
        {
            get { return this._quantity; }
            set
            {
                // Make sure the quantity is never negative
                this._quantity = value;
                if (this._quantity < 1)
                    this._quantity = 0;
            }
        }

        public int OfferID { get; set; }

        [Required]
        [StringLength(60)]
        public string OfferDescription { get; set; }

        [Required]
        [StringLength(10)]
        public string ShortDescription { get; set; }

        public int? TFTPOTGroup { get; set; }

        public int? DiscountPercentage { get; set; }

        [NotMapped]
        public List<int> Products { get; set; }

        public override string ToString()
        {
            return OfferDescription;
        }
    }
}
