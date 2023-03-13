using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itlapr.BLL.Models
{
    public class EmployeesModel
    {
        public int empId { get; set; }
        public DateTime HireDate { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string StartHireDateDisplay
        {
            get { return this.HireDate.ToString("dd/MM/yyyy"); }
        }
    }
}
