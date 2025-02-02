﻿

using AutoMapper;
using MagazineWebApi.ApplicationServices.API.Domain.Get;
using MagazineWebApi.ApplicationServices.API.Domain.Models;
using MagazineWebApi.DataAccess.CQRS;
using MagazineWebApi.DataAccess.CQRS.Queries;
using MediatR;

namespace MagazineWebApi.ApplicationServices.API.Handlers
{
    public class GetMedicinesHandler : IRequestHandler<GetMedicinesRequest, GetMedicinesResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetMedicinesHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetMedicinesResponse> Handle(GetMedicinesRequest request, CancellationToken cancellationToken)
        {
            //var query = new GetMedicinesQuery()
            //{
            //Name = request.Name,
            //};
            var query = this.mapper.Map<GetMedicinesQuery>(request);
            var medicines = await this.queryExecutor.Execute(query);
            var mappedMedicine = this.mapper.Map<List<Medicine>>(medicines);
            var response = new GetMedicinesResponse()
            {
                Data = mappedMedicine
            };
            return response;
        }
    }
}
