
using MagazineWebApi.DataAccess.Entities;
using MediatR;

namespace MagazineWebApi.ApplicationServices.API.Domain.Add
{
    public class AddInvoiceRequest: IRequest<AddInvoiceResponse>
    {
        public string Number { get; set; }
        public int WholesaleId { get; set; }
        public int EmployeeId { get; set; }
    }
}
