namespace itlapr.Web.Models.Response
{
    public class EmployeesListResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public List<EmployeesModel> data { get; set; }
    }
}
