using itlapr.BLL.Core;
using itlapr.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itlapr.BLL.Contract
{
    public interface IEmployeesService : IBaseService
    {
        ServiceResult SaveEmployees(EmployeesAddDto employeesAddDto);
        ServiceResult DeleteEmployees(EmployeesRemoveDto employeesRemoveDto);
        ServiceResult UpdateEmployees(EmployeesUpdateDto employeesUpdateDto);
    }
}
