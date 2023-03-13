using itla.API.Request;
using itlapr.BLL.Contract;
using itlapr.BLL.Dtos;
using itlapr.DAL.Entity;
using itlapr.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace itla.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployessController : ControllerBase
    {
       
        private readonly IEmployeesService employeesService;

        public EmployessController(IEmployeesService employeesService)
        {
            this.employeesService = employeesService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = this.employeesService.GetAll();

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = this.employeesService.GetById(id);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost("Save")]
        public IActionResult Post([FromBody] EmployeesAddDto employeesAddDto)
        {
            var result = this.employeesService.SaveEmployees(employeesAddDto);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Put([FromBody]EmployeesUpdateDto employeesUpdateDto)
        {
            var result = this.employeesService.UpdateEmployees(employeesUpdateDto);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result); ;
        }

        [HttpPost("Remove")]
        public IActionResult Remove([FromBody] EmployeesRemoveDto employeesRemoveDto)
        {
            var result = this.employeesService.DeleteEmployees(employeesRemoveDto);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
    }
}
