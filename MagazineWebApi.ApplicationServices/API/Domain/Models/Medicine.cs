namespace MagazineWebApi.ApplicationServices.API.Domain.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Dose { get; set; }
        public string? PackSize { get; set; }
        public string ExpirationDate { get; set; }
        public string Series { get; set; }
    }
}
