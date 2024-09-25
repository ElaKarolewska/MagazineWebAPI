using MagazineWebApi.ApplicationServices.API.Domain.Add;
using MagazineWebApi.ApplicationServices.API.Domain.Get;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MagazineWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvoicesController: ControllerBase
    {
        private readonly IMediator mediator;
        public InvoicesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllInvoices([FromQuery] GetInvoicesRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddInvoice([FromBody] AddInvoiceRequest request)
        {
            var response = await mediator.Send(request);
            return this.Ok(response);
        }
    }

    
}
