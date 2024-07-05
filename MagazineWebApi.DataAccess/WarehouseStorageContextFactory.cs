
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MagazineWebApi.DataAccess
{
    public class WarehouseStorageContextFactory : IDesignTimeDbContextFactory<WarehouseStorageContext>
    {
        public WarehouseStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WarehouseStorageContext>();
            optionsBuilder.UseSqlServer("Data Source=KAROL\\SQLEXPRESS;Initial Catalog=WarehouseStorage;Integrated Security=True;Encrypt=False");
            return new WarehouseStorageContext(optionsBuilder.Options);
        }
    }
}
