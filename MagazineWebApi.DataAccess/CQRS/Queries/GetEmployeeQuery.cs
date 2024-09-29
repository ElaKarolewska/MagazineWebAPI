

using MagazineWebApi.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace MagazineWebApi.DataAccess.CQRS.Queries
{
    public class GetEmployeeQuery : QueryBase<Employee>
    {
        public int Id { get; set; }
        public override async Task<Employee> Execute(WarehouseStorageContext context)
        {
            var employee = await context.Employees.FirstOrDefaultAsync(x => x.Id == this.Id);
            return employee;
        }
    }
}
