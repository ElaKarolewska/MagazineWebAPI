

using AutoMapper;
using MagazineWebApi.ApplicationServices.API.Domain;
using MagazineWebApi.DataAccess;
using MagazineWebApi.DataAccess.Entities;
using MediatR;

namespace MagazineWebApi.ApplicationServices.API.Handlers
{
    public class GetMedicinesHandler : IRequestHandler<GetMedicinesRequest, GetMedicinesResponse>
    {
        private readonly IRepository<Medicine> medicineRepository;
        private readonly IMapper mapper;

        public GetMedicinesHandler(IRepository<DataAccess.Entities.Medicine> medicineRepository, IMapper mapper)
        {
            this.medicineRepository = medicineRepository;
            this.mapper = mapper;
        }
        public async Task<GetMedicinesResponse> Handle(GetMedicinesRequest request, CancellationToken cancellationToken)
        {
            var medicines = await this.medicineRepository.GetAll();
            var mappedMedicines = this.mapper.Map<List<Domain.Models.Medicine>>(medicines);
            var response = new GetMedicinesResponse()
            {
                Data = mappedMedicines
            };
            return response;
        }
    }
}
