using itlapr.DAL.Entities;

namespace itlapr.DAL.Core
{
    public abstract class ProductN : AuditEntity
    {
        public string? productname { get; set; }
        public string? categoryname { get; set; }
    }
}
    