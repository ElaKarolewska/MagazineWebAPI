
using System.ComponentModel.DataAnnotations;

namespace MagazineWebApi.DataAccess.Entities
{
    public class Wholesale: EntityBase
    {   
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        public List <Invoice> Invoices { get; set; }
    }
}
