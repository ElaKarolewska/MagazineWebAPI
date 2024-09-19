using MagazineWebApi.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazineWebApi.DataAccess.CQRS.Queries
{
    public class GetMedicineQuery : QueryBase<Medicine>
    {
        public int Id { get; set; }
        public override async Task<Medicine> Execute(WarehouseStorageContext context)
        {
            var medicine = await context.Medicines.FirstOrDefaultAsync(x => x.Id == this.Id);
            return medicine;
        }
    }
}
