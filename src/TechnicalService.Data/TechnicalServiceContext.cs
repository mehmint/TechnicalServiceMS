using System.Data.Entity;
using TechnicalService.Core.Entities;

namespace TechnicalService.Data
{
    public class TechnicalServiceContext : DbContext
    {
        public TechnicalServiceContext() 
            : base("name=TechnicalServiceDB")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ServiceRequest> ServiceRecords { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Users { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Customer tablosu için konfigürasyon
            modelBuilder.Entity<Customer>()
                .Property(c => c.CreditCardInfo)
                .HasMaxLength(500); // Encrypted data için

            modelBuilder.Entity<Customer>()
                .Property(c => c.BusinessName)
                .HasMaxLength(200);

            // ServiceRequest tablosu için konfigürasyon
            modelBuilder.Entity<ServiceRequest>()
                .Property(s => s.Status)
                .HasMaxLength(50);
        }
    }
}
