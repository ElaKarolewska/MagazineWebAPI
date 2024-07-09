using MagazineWebApi.DataAccess;
using MagazineWebApi.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MagazineWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicinesController: ControllerBase
    {
        private readonly IRepository<Medicine> medicineRepository;
        public MedicinesController(IRepository<Medicine> medicineRepository)
        {
            this.medicineRepository = medicineRepository;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Medicine> GetAllMedicines()
        {
            return this.medicineRepository.GetAll();
        }

        [HttpGet]
        [Route("{medicineId}")]
        public Medicine GetMedicineById(int medicineId)
        {
            return this.medicineRepository.GetById(medicineId);
        }
    }
}
