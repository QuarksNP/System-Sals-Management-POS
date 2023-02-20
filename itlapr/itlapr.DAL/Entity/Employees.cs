using itlapr.DAL.Core;

namespace itlapr.DAL.Entity
{
    public class Employees : Person
    {
        public int Id { get; set; }
        public DateTime HireDate { get; set; }
    }
}
