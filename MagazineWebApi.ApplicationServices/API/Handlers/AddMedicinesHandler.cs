using AutoMapper;
using MagazineWebApi.ApplicationServices.API.Domain;
using MagazineWebApi.DataAccess.CQRS;
using MagazineWebApi.DataAccess.CQRS.Commands;
using MagazineWebApi.DataAccess.Entities;
using MediatR;

namespace MagazineWebApi.ApplicationServices.API.Handlers
{
    public class AddMedicinesHandler : IRequestHandler<AddMedicinesRequest, AddMedicinesResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;
        public AddMedicinesHandler(ICommandExecutor commandEexecutor, IMapper mapper)
        {
            this.commandExecutor =commandEexecutor;
            this.mapper = mapper;
        }

        public async Task<AddMedicinesResponse> Handle(AddMedicinesRequest request, CancellationToken cancellationToken)
        {
            var medicine = mapper.Map<Medicine>(request);
            var command = new AddMedicineCommand() { Parametr = medicine };
            var medicineFromDb = await commandExecutor.Execute(command);
            return new AddMedicinesResponse()
            {
                Data = mapper.Map<Domain.Models.Medicine >(medicineFromDb)
            };
        }
    }
}
