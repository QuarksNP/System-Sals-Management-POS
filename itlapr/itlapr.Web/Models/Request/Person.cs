namespace itlapr.Web.Models.Request
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime hireDate { get; set; }
        public string? title { get; set; }
        public string? titleOfCourtesy { get; set; }
        public string? address { get; set; }
        public int mGrid { get; set; }
        public string? city { get; set; }
        public string? country { get; set; }
        public string? region { get; set; }
        public string? postalCode { get; set; }
        public string? phone { get; set; }
    }
}
