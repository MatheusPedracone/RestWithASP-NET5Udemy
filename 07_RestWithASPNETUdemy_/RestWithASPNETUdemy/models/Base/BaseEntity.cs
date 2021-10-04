using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.models.Base
{
    public class BaseEntity
    {
         [Column("id")]
            public long Id { get; set; }
    }
}