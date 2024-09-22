using MediatR;

namespace MagazineWebApi.ApplicationServices.API.Domain
{
    public class AddMedicinesRequest :IRequest<AddMedicinesResponse>
    {
        public string Name { get; set; }
    }
}
