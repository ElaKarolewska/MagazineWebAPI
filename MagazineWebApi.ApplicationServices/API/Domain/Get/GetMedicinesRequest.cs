using MediatR;

namespace MagazineWebApi.ApplicationServices.API.Domain.Get
{
    public class GetMedicinesRequest : IRequest<GetMedicinesResponse>
    {
        public string Name { get; set; }
    }
}
