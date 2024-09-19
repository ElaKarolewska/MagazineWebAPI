

using AutoMapper;
using MagazineWebApi.ApplicationServices.API.Domain;
using MagazineWebApi.DataAccess;
using MagazineWebApi.DataAccess.CQRS.Queries;
using MagazineWebApi.DataAccess.Entities;
using MediatR;

namespace MagazineWebApi.ApplicationServices.API.Handlers
{
    public class GetMedicinesHandler : IRequestHandler<GetMedicinesRequest, GetMedicinesResponse>
    {
        private readonly IMapper mapper;

        public GetMedicinesHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetMedicinesResponse> Handle(GetMedicinesRequest request, CancellationToken cancellationToken)
        {
            var query = new GetMedicineQuery();
            var medicines = await this.queryExecutor.Execute(query);
            var mappedMedicines = this.mapper.Map<List<Domain.Models.Medicine>>(medicines);
            var response = new GetMedicinesResponse()
            {
                Data = mappedMedicines
            };
            return response;
        }
    }
}
