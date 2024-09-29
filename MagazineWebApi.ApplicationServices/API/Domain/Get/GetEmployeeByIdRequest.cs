
using MediatR;

namespace MagazineWebApi.ApplicationServices.API.Domain.Get
{
    public class GetEmployeeByIdRequest: IRequest<GetEmployeeByIdResponse>
    {
        public int EmployeeId { get; set; }
    }
}
