using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itlapr.BLL.Dtos
{
    public class EmployeesAddDto
    {
        public int empId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime HireDate { get; set; }
        public string? title { get; set; }
        public string? titleOfCourtesy { get; set; }
        public string? address { get; set; }
        public int mGrid { get; set; }
        public string? city { get; set; }
        public string? country { get; set; }
        public string? region { get; set; }
        public int postalCode { get; set; }
        public string? phone { get; set; }

    }
}
