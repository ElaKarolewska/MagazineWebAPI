
using AutoMapper;
using MagazineWebApi.ApplicationServices.API.Domain.Get;
using MagazineWebApi.ApplicationServices.API.Domain.Models;
using MagazineWebApi.DataAccess.CQRS;
using MagazineWebApi.DataAccess.CQRS.Queries;
using MediatR;

namespace MagazineWebApi.ApplicationServices.API.Handlers
{
    
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdRequest, GetEmployeeByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;
        public GetEmployeeByIdHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetEmployeeByIdResponse> Handle(GetEmployeeByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetEmployeeQuery()
            {
                Id = request.EmployeeId
            };
            var employee = await queryExecutor.Execute(query);
            var mappedEmployee = mapper.Map<Employee>(employee);
            var response = new GetEmployeeByIdResponse()
            {
                Data = mappedEmployee
            };
            return response;


        }
    }
}
