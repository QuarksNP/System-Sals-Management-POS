namespace itlapr.Web.Models
{
    public class ProductModel
    {
        public int productId { get; set; }
        public string? productName { get; set; }
        public int supplierId { get; set; }
        public int categoryId { get; set;}
        public double unitPrice { get; set; }
        public byte discontinued { get; set; }
    }
}
