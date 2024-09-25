using AutoMapper;
using MagazineWebApi.ApplicationServices.API.Domain.Get;
using MagazineWebApi.DataAccess;
using MagazineWebApi.DataAccess.CQRS;
using MagazineWebApi.DataAccess.CQRS.Queries;
using MediatR;


namespace MagazineWebApi.ApplicationServices.API.Handlers
{
    public class GetInvoicesHandler : IRequestHandler<GetInvoicesRequest, GetInvoicesResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetInvoicesHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this .mapper = mapper;
            this .queryExecutor = queryExecutor;
        }
        public async Task<GetInvoicesResponse> Handle(GetInvoicesRequest request, CancellationToken cancellationToken)
        {
            var query = new GetInvoicesQuery();
            var invoices = await this.queryExecutor.Execute(query);
            var mappedInvoice = this.mapper.Map<List<Domain.Models.Invoice>>(invoices);
            var response = new GetInvoicesResponse()
            {
                Data = mappedInvoice,
            };
            return response;
        }
    }
}
