using MagazineWebApi.ApplicationServices.API.Domain;
using MagazineWebApi.DataAccess;
using MagazineWebApi.DataAccess.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MagazineWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicinesController : ControllerBase
    {
            private readonly IMediator mediator;
            public MedicinesController(IMediator mediator)
            {
                this.mediator = mediator;
            }

            [HttpGet]
            [Route("")]
            public async Task<IActionResult> GetAllMedicines([FromQuery] GetMedicinesRequest request)
            {
                var response = await this.mediator.Send(request);
                return this.Ok(response);
            }



        //private readonly IRepository<Medicine> medicineRepository;
        //public MedicinesController(IRepository<Medicine> medicineRepository)
        //{
        //    this.medicineRepository = medicineRepository;
        //}

        //[HttpGet]
        //[Route("")]
        //public IEnumerable<Medicine> GetAllMedicines()
        //{
        //    return this.medicineRepository.GetAll();
        //}

        //[HttpGet]
        //[Route("{medicineId}")]
        //public Medicine GetMedicineById(int medicineId)
        //{
        //    return this.medicineRepository.GetById(medicineId);
        //}
    }
}
