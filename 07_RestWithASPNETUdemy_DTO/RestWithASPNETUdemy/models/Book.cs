using System.ComponentModel.DataAnnotations.Schema;
using RestWithASPNETUdemy.models.Base;

namespace RestWithASPNETUdemy.models
{
    public class Book : BaseEntity
    {
        public string Tittle { get; set; }
        public string Author { get; set; }
        public string Price { get; set; }
        public string LaunchDate { get; set; }
    }
}

