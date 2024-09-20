

using MagazineWebApi.DataAccess.Entities;

namespace MagazineWebApi.DataAccess.CQRS.Commands
{
    public class AddMedicineCommand : CommandBase<Medicine, Medicine>
    {
        public override async Task<Medicine> Execute(WarehouseStorageContext context)
        {
            await context.Medicines.AddAsync(this.Parametr);
            await context.SaveChangesAsync();
            return this.Parametr;
        }
    }
}
