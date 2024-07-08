

using System.ComponentModel.DataAnnotations;

namespace MagazineWebApi.DataAccess.Entities
{
    public abstract class EntityBase
    {
      [Key]
      public int Id { get; set; }
    }
}
