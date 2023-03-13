namespace itla.API.Request
{
    public class EmployeesRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Title { get; set; }
        public string? TitleOfCourtesy { get; set; }
        public DateTime HireDate { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public int PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }

        public int Mgrid { get; set; }

    }
}
