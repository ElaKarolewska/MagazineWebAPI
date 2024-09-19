using AutoMapper;
using MagazineWebApi.ApplicationServices.API.Domain.Models;

namespace MagazineWebApi.ApplicationServices.Mappings
{
    public class InvoicesProfile: Profile
    {
        public InvoicesProfile()
        {
            this.CreateMap<DataAccess.Entities.Invoice, Invoice>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Number, y => y.MapFrom(z => z.Number));
        }
    }
}
