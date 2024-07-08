
using System.ComponentModel.DataAnnotations;

namespace MagazineWebApi.DataAccess.Entities
{
    public class Medicine: EntityBase
    {
        public List<Invoice> Invoices { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
       
        [Required]
        [MaxLength(100)]
        public string? Dose { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string? PackSize { get; set; }
        
        public double Price { get; set; }

    }
}
