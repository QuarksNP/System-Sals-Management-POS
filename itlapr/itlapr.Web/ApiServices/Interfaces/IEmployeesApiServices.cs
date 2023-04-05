using itlapr.Web.Models.Request;
using itlapr.Web.Models.Response;

namespace itlapr.Web.ApiServices.Interfaces
{
    public interface IEmployeesApiServices
    {
        Task<EmployeesListResponse> GetEmployees();
        Task<EmployeeResponse> GetEmployee(int Id);
        Task<BaseResponse> Update(EmployeeUpdateRequest employeeModel);
        Task<BaseResponse> Save(EmployeeCreateRequest employeeModel);
    }
}
