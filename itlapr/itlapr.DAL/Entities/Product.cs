using itlapr.DAL.Core;

namespace itlapr.DAL.Entities
{
    public class Product : ProductN
    {
       public int ProductId { get; set; }
       public string ProductName { get; set; } 
       public string Description { get; set; } 
    }
}
