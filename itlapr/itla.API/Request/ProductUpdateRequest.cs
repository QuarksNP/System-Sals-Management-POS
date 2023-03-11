namespace itla.API.Requests
{
    public class ProductUpdateRequest : UpdateRequestBase
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
    }
}
