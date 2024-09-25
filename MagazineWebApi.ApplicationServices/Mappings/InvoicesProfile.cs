using AutoMapper;
using MagazineWebApi.ApplicationServices.API.Domain.Add;
using MagazineWebApi.ApplicationServices.API.Domain.Models;

namespace MagazineWebApi.ApplicationServices.Mappings
{
    public class InvoicesProfile: Profile
    {
        public InvoicesProfile()
        {
            CreateMap<AddInvoiceRequest, DataAccess.Entities.Invoice>()
                .ForMember(x => x.Number, y => y.MapFrom(z => z.Number));
            
            CreateMap<DataAccess.Entities.Invoice, Invoice>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Number, y => y.MapFrom(z => z.Number));
        }
    }
}
