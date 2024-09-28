
using AutoMapper;
using MagazineWebApi.ApplicationServices.API.Domain;
using MagazineWebApi.ApplicationServices.API.Domain.Get;
using MagazineWebApi.ApplicationServices.API.Domain.Models;
using MagazineWebApi.DataAccess.CQRS.Queries;

namespace MagazineWebApi.ApplicationServices.Mappings
{
    public class MedicinesProfile: Profile
    {
        public MedicinesProfile()
        {
            this.CreateMap<DataAccess.Entities.Medicine, Medicine>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Dose, y => y.MapFrom(z => z.Dose))
                .ForMember(x => x.ExpirationDate, y => y.MapFrom(z => z.ExpirationDate))
                .ForMember(x => x.Series, y => y.MapFrom(z => z.Series));

                CreateMap<GetMedicinesRequest, GetMedicinesQuery>();
                                                                                                     // Przykład mapowania encji na DTO
            
        }

    }
}

