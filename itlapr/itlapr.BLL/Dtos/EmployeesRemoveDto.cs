using itlapr.BLL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itlapr.BLL.Dtos
{
    public class EmployeesRemoveDto : Person
    {
        public int empId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime HireDate { get; set; }

    }
}
