using itlapr.DAL.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace itlapr.DAL.Entity
{

    [Table("Employees", Schema ="HR")]
    public class Employees : Person
    {

        [Key]
        public int empId { get; set; }

        [Column("hiredate")]
        public DateTime HireDate { get; set; }

        [Column("title")]
        public string? title { get; set; }

        [Column("titleofcourtesy")]
        public string? titleOfCourtesy { get; set; }

        [Column("address")]
        public string? address { get; set; }

        [Column("mgrid")]
        public int mGrid { get; set; }

        [Column("city")]
        public string? city { get; set; }

        [Column("country")]
        public string? country { get; set; }

        [Column("region")]
        public string? region { get; set; }

        [Column("postalcode")]
        public int postalCode { get; set; }

        [Column("phone")]
        public string? phone { get; set; }

    }
}
        