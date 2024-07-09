using MagazineWebApi.ApplicationServices.API.Domain;
using MagazineWebApi.DataAccess;
using MagazineWebApi.DataAccess.Entities;
using MediatR;

namespace MagazineWebApi.ApplicationServices.API.Handlers
{
    public class GetInvoicesHandler : IRequestHandler<GetInvoicesRequest, GetInvoicesResponse>
    {
        private readonly IRepository<Invoice> invoiceRepository;

        public GetInvoicesHandler(IRepository<DataAccess.Entities.Invoice> invoiceRepository)
        {
            this.invoiceRepository = invoiceRepository;
        }
        public Task<GetInvoicesResponse> Handle(GetInvoicesRequest request, CancellationToken cancellationToken)
        {
            var invoice = this.invoiceRepository.GetAll();
            var domainInvoice = invoice.Select(x => new Domain.Models.Invoice()
            {
                Id = x.Id,
                Number = x.Number,
            });
            
            var response = new GetInvoicesResponse()
            {
                Data = domainInvoice.ToList(),
            };

            return Task.FromResult(response);
        }
    }
}
