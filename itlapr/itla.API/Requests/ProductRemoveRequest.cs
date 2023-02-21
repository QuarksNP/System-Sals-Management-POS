namespace itla.API.Requests
{
    public class ProductRemoveRequest : RemoveRequestBase
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
