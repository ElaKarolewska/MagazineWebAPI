using MagazineWebApi.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace MagazineWebApi.DataAccess
{
    public class WarehouseStorageContext: DbContext
    {
        public WarehouseStorageContext(DbContextOptions<WarehouseStorageContext> opt) : base(opt)
        {
        }
        public DbSet<Medicine>Medicines { get; set; }
        public DbSet<Invoice>Invoices { get; set; }
        public DbSet<Wholesale> Wholesales { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
