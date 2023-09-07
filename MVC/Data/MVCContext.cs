using Microsoft.EntityFrameworkCore;
using MVC.Models;

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
    }
}