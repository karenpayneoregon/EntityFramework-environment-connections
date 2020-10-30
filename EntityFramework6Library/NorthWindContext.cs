using EntityFramework6Library.Models;

namespace EntityFramework6Library
{

    using System.Data.Entity;

    public partial class NorthWindContext : DbContext
    {

#if Dev
        public NorthWindContext() : base("name=DevConnection")
#elif Staging
        public NorthWindContext() : base("name=StagingConnection")
#else
        public NorthWindContext() : base("name=ProductionConnection")
#endif
        { }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}