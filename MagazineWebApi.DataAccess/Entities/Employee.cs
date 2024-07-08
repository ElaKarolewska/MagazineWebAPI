using System.ComponentModel.DataAnnotations;

namespace MagazineWebApi.DataAccess.Entities
{
    public  class Employee: EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Surname { get; set; }

        public List <Invoice> Invoices { get; set; }

    }
}
