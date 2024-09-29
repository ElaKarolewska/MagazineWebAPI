using MagazineWebApi.ApplicationServices.API.Domain.Get;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MagazineWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator mediator;
        public EmployeeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("{employeeId}")]
        public async Task<IActionResult> GetById([FromRoute] int employeeId)
        {
            var request = new GetEmployeeByIdRequest()
            {
                EmployeeId = employeeId
            };
            var response = await this.mediator.Send(request);
            return this.Ok(response); 
        }

    }
}
