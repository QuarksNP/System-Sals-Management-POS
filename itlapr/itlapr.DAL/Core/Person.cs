using System.ComponentModel.DataAnnotations.Schema;

namespace itlapr.DAL.Core
{
    public abstract class Person
    {
        [Column("firstname")]
        public string? firstName { get; set; }

        [Column("lastname")]
        public string? lastName { get; set; }
     
    }
}
