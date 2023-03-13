using itlapr.BLL.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itlapr.BLL.Dtos
{
    public class EmployeesUpdateDto : Person
    {
        public int empId { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public DateTime hireDate { get; set; }
    }
}
