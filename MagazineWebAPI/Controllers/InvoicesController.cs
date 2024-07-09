using MagazineWebApi.ApplicationServices.API.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

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
    }
    
}
