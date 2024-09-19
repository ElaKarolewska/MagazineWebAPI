

using MagazineWebApi.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace MagazineWebApi.DataAccess.CQRS.Queries
{
    public class GetMedicinesQuery: QueryBase<List<Medicine>>
    {
        public int Id { get; set; }
        public override Task<List<Medicine>> Execute(WarehouseStorageContext context)
        {
            return context.Medicines.ToListAsync();
          
        }
    }
}
