namespace Supermarket
{
    using System.Data.Entity;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=AzureDB")
        {
        }

        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Offer>()
                 //.Property(e => e.ShortDescription)
                 //.IsFixedLength()
                 .HasKey(k => k.OfferID);

            modelBuilder.Entity<Product>()
                //.Property(e => e.UnitPrice)
                //.HasPrecision(19, 4)
                .HasKey(k => k.ProductID);
        }
    }
}
