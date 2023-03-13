using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itlapr.BLL.Exceptions
{
    public class EmployeesException : Exception
    {
        public EmployeesException(string message) : base(message) 
        {

        }
    }
}
