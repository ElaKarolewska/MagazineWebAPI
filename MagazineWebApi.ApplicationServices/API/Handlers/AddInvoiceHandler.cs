
using AutoMapper;
using MagazineWebApi.ApplicationServices.API.Domain.Add;
using MagazineWebApi.ApplicationServices.API.Domain.Models;
using MagazineWebApi.DataAccess.CQRS;
using MagazineWebApi.DataAccess.CQRS.Commands;
using MediatR;
using MagazineWebApi.DataAccess.Entities;


namespace MagazineWebApi.ApplicationServices.API.Handlers
{
    public class AddInvoiceHandler : IRequestHandler<AddInvoiceRequest, AddInvoiceResponse>
    {
        private readonly ICommandExecutor _commandExecutor;
        private readonly IMapper _mapper;
        public AddInvoiceHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
             _commandExecutor = commandExecutor;
            _mapper = mapper; 
        }

        public async Task<AddInvoiceResponse> Handle(AddInvoiceRequest request, CancellationToken cancellationToken)
        {
            var invoice = _mapper.Map<DataAccess.Entities.Invoice>(request);
            var command = new AddInvoiceCommand() { Parametr = invoice };
            var invoiceFromDb = await _commandExecutor.Execute(command);
            return new AddInvoiceResponse()
            {
                Data = _mapper.Map<Domain.Models.Invoice>(invoiceFromDb)
            };
        }
    }
}
