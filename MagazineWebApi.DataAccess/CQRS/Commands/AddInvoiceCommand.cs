
using MagazineWebApi.DataAccess.Entities;

namespace MagazineWebApi.DataAccess.CQRS.Commands
{
    public class AddInvoiceCommand : CommandBase<Invoice, Invoice>
    {
        public override async Task<Invoice> Execute(WarehouseStorageContext context)
        {
            await context.Invoices.AddAsync(Parametr);
            await context.SaveChangesAsync();
            return Parametr;
        }
    }
}
