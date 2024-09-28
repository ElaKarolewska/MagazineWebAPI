

using MagazineWebApi.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace MagazineWebApi.DataAccess.CQRS.Queries
{
    public class GetMedicinesQuery: QueryBase<List<Medicine>>
    {
        public string Name { get; set; }
        public override Task<List<Medicine>> Execute(WarehouseStorageContext context)
        {
                return Name == null
                ? context.Medicines.ToListAsync()
                : context.Medicines.Where(x => x.Name == this.Name).ToListAsync();
    
        }
    }
}
