using Microsoft.EntityFrameworkCore;
using MVC.Models;
using MVC.Models.Logs;

namespace MVC.Data
{
    public class MVCContext : DbContext
    {
        public MVCContext(DbContextOptions<MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller> Sellers { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecords { get; set; } = default!;
        public DbSet<SalesLog> SalesLogs { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesLog>()
                .HasOne(sl => sl.SalesRecord)
                .WithMany(sr => sr.SalesLog)
                .HasForeignKey(sl => sl.SalesRecordId);
        }
    }
}