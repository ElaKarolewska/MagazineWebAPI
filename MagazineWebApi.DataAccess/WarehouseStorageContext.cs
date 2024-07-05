

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
    }
}
