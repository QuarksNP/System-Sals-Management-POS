using itlapr.Web.Models.Request;
using itlapr.Web.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace itlapr.Web.Controllers
{
    public class EmployeesController : Controller
    {
        HttpClientHandler httpClientHandler = new HttpClientHandler();
        private ILogger<EmployeesController> logger;
        private IConfiguration configuration;

        public EmployeesController(ILogger<EmployeesController> logger, IConfiguration configuration)
        {
            this.logger = logger;
            this.configuration = configuration;
        }
        // GET: EmployeesController
        public async Task <ActionResult> Index()
        {
            EmployeesListResponse employeesListResponse = new EmployeesListResponse();

            try
            {
                using (var httpClient = new HttpClient(this.httpClientHandler))
                {
                   var resultApi =  await httpClient.GetAsync("http://localhost:5144/api/Employess");

                    if(resultApi.IsSuccessStatusCode)
                    {
                        string apiResponse = await resultApi.Content.ReadAsStringAsync();
                        employeesListResponse = JsonConvert.DeserializeObject<EmployeesListResponse>(apiResponse);
                    }

                    else
                    {
                        
                    }
                }

                return View(employeesListResponse.data);


            }

            catch (Exception ex)
            {
                this.logger.LogError("Error getting employee", ex.ToString());
            }
            return View();
        }

        // GET: EmployeesController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            EmployeeResponse employeeResponse = new EmployeeResponse();

            using (var httpClient = new HttpClient(this.httpClientHandler))
            {
                var resultApi = await httpClient.GetAsync("http://localhost:5144/api/Employess/" + id);

                if (resultApi.IsSuccessStatusCode)
                {
                    string apiResponse = await resultApi.Content.ReadAsStringAsync();
                    employeeResponse = JsonConvert.DeserializeObject<EmployeeResponse>(apiResponse);
                }

                else
                {

                }

            }
            return View(employeeResponse.data); 
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EmployeeCreateRequest employeeCreateRequest)
        {
            BaseResponse baseResponse = new BaseResponse();
            try
            {
                employeeCreateRequest.hireDate = DateTime.Now;
                using (var httpClient = new HttpClient(this.httpClientHandler))
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(employeeCreateRequest), Encoding.UTF8, "application/json");

                    var response = await httpClient.PostAsync("http://localhost:5144/api/Employess/Save", content);

                    string apiResponse = await response.Content.ReadAsStringAsync();

                    baseResponse = JsonConvert.DeserializeObject<BaseResponse>(apiResponse);

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.Message = baseResponse.Message;
                        return View();
                    }

                }


            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            EmployeeResponse employeeResponse = new EmployeeResponse();

            using (var httpClient = new HttpClient(this.httpClientHandler))
                {
                    var resultApi = await httpClient.GetAsync("http://localhost:5144/api/Employess/" + id);

                    if (resultApi.IsSuccessStatusCode)
                    {
                        string apiResponse = await resultApi.Content.ReadAsStringAsync();
                        employeeResponse = JsonConvert.DeserializeObject<EmployeeResponse>(apiResponse);
                    }

                    else
                    {

                    }

            }       return View(employeeResponse.data);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult> Edit(EmployeeUpdateRequest employeeUpdateRequest)
        {
            BaseResponse baseResponse = new BaseResponse();
            try
            {
             
                using (var httpClient = new HttpClient(this.httpClientHandler))
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(employeeUpdateRequest), Encoding.UTF8, "application/json");

                    var response = await httpClient.PostAsync("http://localhost:5144/api/Employess/Update", content);

                    string apiResponse = await response.Content.ReadAsStringAsync();

                    baseResponse = JsonConvert.DeserializeObject<BaseResponse>(apiResponse);

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.Message = baseResponse.Message;
                        return View();
                    }

                }


            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
