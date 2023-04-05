using itlapr.Web.ApiServices.Interfaces;
using itlapr.Web.Models.Request;
using itlapr.Web.Models.Response;
using Newtonsoft.Json;

namespace itlapr.Web.ApiServices.Services
{
    public class EmployeesApiServices : IEmployeesApiServices
    {
        private readonly IHttpClientFactory httpClientFactory;
        private readonly IConfiguration configuration;
        private readonly ILogger<EmployeesApiServices> logger;
        private readonly string baseUrl;
        public EmployeesApiServices(IHttpClientFactory httpClientFactory,
                                 IConfiguration configuration,
                                 ILogger<EmployeesApiServices> logger)
        {
            this.httpClientFactory = httpClientFactory;
            this.configuration = configuration;
            this.logger = logger;
            this.baseUrl = this.configuration["ApiConfig:baseUrl"];
        }
        public async Task<EmployeeResponse> GetEmployee(int Id)
        {
            EmployeeResponse employeeResponse = new EmployeeResponse();

            try
            {
                using (var httpClient = this.httpClientFactory.CreateClient())
                {

                    using (var response = await httpClient.GetAsync($"{this.baseUrl}/Employees/" + Id))
                    {

                        if (response.IsSuccessStatusCode)
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            employeeResponse = JsonConvert.DeserializeObject<EmployeeResponse>(apiResponse);
                        }
                        else
                        {
                                 
                        }

                    }

                }
            }

            catch (Exception ex)
            {
                employeeResponse.message = "Error getting Employee";
                employeeResponse.success = false;
                this.logger.LogError(employeeResponse.message, ex.ToString());
            }

            return employeeResponse;
        }

        public async Task<EmployeesListResponse> GetEmployees()
        {
            EmployeesListResponse employeesListResponse = new EmployeesListResponse();

            try
            {
                using (var httpClient = this.httpClientFactory.CreateClient())
                {
                    using (var response = await httpClient.GetAsync($"{this.baseUrl}/Employees"))
                    {

                        if (response.IsSuccessStatusCode)
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            employeesListResponse = JsonConvert.DeserializeObject<EmployeesListResponse>(apiResponse);
                        }
                        else
                        {

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                employeesListResponse.message = "Error getting Employees";
                employeesListResponse.success = false;
                this.logger.LogError(employeesListResponse.message, ex.ToString());
            }

            return employeesListResponse;
        }

        public Task<BaseResponse> Save(EmployeeCreateRequest employeeModel)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse> Update(EmployeeUpdateRequest employeeModel)
        {
            throw new NotImplementedException();
        }
    }
}
