namespace CodeFirstExistingDatabaseSample.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class customerContext : DbContext
    {
        public customerContext()
            : base("name=customerContext")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.PasswordHash)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PasswordSalt)
                .IsUnicode(false);
        }
    }
}
