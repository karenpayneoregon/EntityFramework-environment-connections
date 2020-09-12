using Microsoft.EntityFrameworkCore;
using EntityFrameworkCoreLibrary.Models;
using static System.Configuration.ConfigurationManager;

namespace EntityFrameworkCoreLibrary.Contexts
{
    public partial class NorthWindContext : DbContext
    {
        public NorthWindContext()
        {
        }

        public NorthWindContext(DbContextOptions<NorthWindContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var environment = "";

#if Dev
                environment = "DevConnection";
#elif Staging
                environment = "StagingConnection";
#else
                environment = "ProductionConnection";
#endif
                optionsBuilder.UseSqlServer(AppSettings[environment]);

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ContactsConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
