namespace itla.API.Request
{
    public class EmployessaddRequests : RequestBase
    {
        public int Id { get; set; }
        public DateTime HireDate { get; set; }
        public string? firtsName { get; set; }
        public string? lastName { get; set; }

 
    }
}
