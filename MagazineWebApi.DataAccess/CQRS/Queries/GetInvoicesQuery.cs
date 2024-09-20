using MagazineWebApi.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace MagazineWebApi.DataAccess.CQRS.Queries
{
    public class GetInvoicesQuery : QueryBase<List<Invoice>>
    {
        public override Task<List<Invoice>> Execute(WarehouseStorageContext context)
        {
            return context.Invoices.ToListAsync();
        }
    }
}
