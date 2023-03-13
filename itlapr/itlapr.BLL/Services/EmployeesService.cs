using itlapr.BLL.Contract;
using itlapr.BLL.Core;
using itlapr.BLL.Dtos;
using itlapr.BLL.Extentions;
using itlapr.BLL.Models;
using itlapr.DAL.Entity;
using itlapr.DAL.Interfaces;
using Microsoft.Extensions.Logging;


namespace itlapr.BLL.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly ILogger<EmployeesService> logger;

        public EmployeesService(IEmployeeRepository employeeRepository, ILogger<EmployeesService> logger)
        {
            this.employeeRepository = employeeRepository;
            this.logger = logger;
        }

        public ServiceResult DeleteEmployees(EmployeesRemoveDto employeeRemoveDto)
        {
            ServiceResult serviceResult = new ServiceResult();

            try
            {
                Employees employeesToRemove = this.employeeRepository.GetEntity(employeeRemoveDto.empId);
                {
                    employeesToRemove.firstName = employeeRemoveDto.FirstName;
                    employeesToRemove.lastName = employeeRemoveDto.LastName;
                    employeesToRemove.mGrid = employeeRemoveDto.mGrid;
                    employeesToRemove.address = employeeRemoveDto.address;
                    employeesToRemove.title = employeeRemoveDto.title;
                    employeesToRemove.country = employeeRemoveDto.country;
                    employeesToRemove.city = employeeRemoveDto.city;
                    employeesToRemove.phone= employeeRemoveDto.phone;
                    employeesToRemove.postalCode= employeeRemoveDto.postalCode; 
                    employeesToRemove.HireDate= employeeRemoveDto.HireDate;

                    this.employeeRepository.Remove(employeesToRemove);
                    serviceResult.Success = true;
                    serviceResult.Message = "The employee has been deleted successfully";
                    this.employeeRepository.SaveChanges();

                };
          
            }

            catch (Exception ex)
            {
                serviceResult.Success = false;
                serviceResult.Message = "Error removing the Employee";
                this.logger.LogError($"{serviceResult.Message}", ex.ToString());
            }

            return serviceResult;
        }

        public ServiceResult GetAll()
        {
            ServiceResult serviceResult = new ServiceResult();

            try
            {
                this.logger.LogInformation("Consulting the Employees");
                var employees = this.employeeRepository.GetEntities().Select(emp => new EmployeesModel()
                {
                    empId = emp.empId,
                    HireDate = emp.HireDate,
                    firstName = emp.firstName,
                    lastName = emp.lastName

                }).ToList();

                serviceResult.Data= employees;
                serviceResult.Success = true;
                this.logger.LogInformation("Consulted the Employees");

            }

            catch (Exception ex)
            {
                serviceResult.Success = false;
                serviceResult.Message = "Error getting the Employees";
                this.logger.LogError($"{serviceResult.Message}", ex.ToString());
            }

            return serviceResult;
        }

        public ServiceResult GetById(int id)
        {
            ServiceResult serviceResult = new ServiceResult();

            try
            {
                this.logger.LogInformation("Consulting the Employees");
                var employees = this.employeeRepository.GetEntity(id);

                EmployeesModel employeesModel = new EmployeesModel()
                {
                    empId = employees.empId,
                    HireDate = employees.HireDate,
                    firstName = employees.firstName,
                    lastName = employees.lastName
                };

                serviceResult.Data = employeesModel;
                serviceResult.Success = true;
                this.logger.LogInformation("Consulted the Employees");

            }

            catch (Exception ex)
            {
                serviceResult.Success = false;
                serviceResult.Message = "Error get the Employee";
                this.logger.LogError($"{serviceResult.Message}", ex.ToString());
            }

            return serviceResult;
        }

        public ServiceResult SaveEmployees(EmployeesAddDto employeesAddDto)
        {
            ServiceResult serviceResult = new ServiceResult();

         
                if (string.IsNullOrEmpty(employeesAddDto.FirstName))
                {
                    serviceResult.Success = false;
                    serviceResult.Message = "The name is required";
                    return serviceResult;
                }

                if (employeesAddDto.FirstName.Length > 50)
                {
                    serviceResult.Success = false;
                    serviceResult.Message = "The lenght is invalid";
                    return serviceResult;
                }

                if (string.IsNullOrEmpty(employeesAddDto.LastName))
                {
                    serviceResult.Success = false;
                    serviceResult.Message = "the lastname is required";
                    return serviceResult;
                }
                if (employeesAddDto.FirstName.Length > 50)
                {
                    serviceResult.Success = false;
                    serviceResult.Message = "the lenght is invalid";
                    return serviceResult;
                }

            try
            {
                Employees employees = employeesAddDto.GetEmployeesEntityFromDtoSave();
                this.employeeRepository.Save(employees);
                serviceResult.Success = true;
                serviceResult.Message = "The employee has been Add succesfully";

            }
     
            catch (Exception ex)
            {
                serviceResult.Message = "Ocurrió un error agregando el estudiante";
                serviceResult.Success = false;
                this.logger.LogError($" {serviceResult.Message} ", ex.ToString());
            }

            return serviceResult;
        }
    


        public ServiceResult UpdateEmployees(EmployeesUpdateDto employeesUpdateDto)
        {
            ServiceResult serviceResult = new ServiceResult();

            try
            {
                if (string.IsNullOrEmpty(employeesUpdateDto.firstName))
                {
                    serviceResult.Success = false;
                    serviceResult.Message = "The name is required";
                    return serviceResult;
                }

                if (employeesUpdateDto.firstName.Length > 50)
                {
                    serviceResult.Success = false;
                    serviceResult.Message = "The lenght is invalid";
                    return serviceResult;
                }

                if (string.IsNullOrEmpty(employeesUpdateDto.lastName))
                {
                    serviceResult.Success = false;
                    serviceResult.Message = "the lastname is required";
                    return serviceResult;
                }
                if (employeesUpdateDto.firstName.Length > 50)
                {
                    serviceResult.Success = false;
                    serviceResult.Message = "the lenght is invalid";
                    return serviceResult;
                }

                Employees employees = this.employeeRepository.GetEntity(employeesUpdateDto.empId);
                employees.firstName = employeesUpdateDto.firstName;
                employees.lastName = employeesUpdateDto.lastName;
                employees.HireDate = employeesUpdateDto.hireDate;
                employees.city = employeesUpdateDto.city;
                employees.title = employeesUpdateDto.title;
                employees.phone = employeesUpdateDto.phone;
                employees.address = employeesUpdateDto.address;
                employees.titleOfCourtesy = employeesUpdateDto.titleOfCourtesy;
         

                this.employeeRepository.Update(employees);
                serviceResult.Success = true;
                serviceResult.Message = "the employee has been update succesfully";
            }

            catch (Exception ex)
            {

                serviceResult.Message = "An error occurred updating the employee";
                serviceResult.Success = false;
                this.logger.LogError($" {serviceResult.Message} ", ex.ToString());
            }
            return serviceResult;
        }
    }
}
