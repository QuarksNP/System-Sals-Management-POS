namespace itlapr.Web.Models.Response
{
    public class EmployeeResponse
    {
        public bool success { get; set; }
        public EmployeesModel data { get; set; }
        public string message { get; set; }
    }
}
