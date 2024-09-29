
using AutoMapper;
using MagazineWebApi.ApplicationServices.API.Domain.Models;


namespace MagazineWebApi.ApplicationServices.Mappings
{
    public class EmployeesProfile: Profile
    {
        public EmployeesProfile()
        {
           CreateMap<DataAccess.Entities.Employee, Employee>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));
        }
    }
}
