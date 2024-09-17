
using AutoMapper;
using MagazineWebApi.ApplicationServices.API.Domain.Models;

namespace MagazineWebApi.ApplicationServices.Mappings
{
    public class MedicinesProfile: Profile
    {
        public MedicinesProfile()
        {
            this.CreateMap<DataAccess.Entities.Medicine, Medicine>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));
        }
    }
}
