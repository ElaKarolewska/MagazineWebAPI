
namespace MagazineWebApi.DataAccess.Entities
{
    public class Invoice : EntityBase
    {
        public int WholesaleId { get; set; }
        public Wholesale Wholesale { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
        public string Number { get; set; }

        public List<Medicine> Medicines { get; set; }
    }
}
