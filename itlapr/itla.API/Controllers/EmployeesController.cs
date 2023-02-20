using itla.API.Request;
using itlapr.DAL.Entity;
using itlapr.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace itlapr.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeesRepository;

        public EmployeeController(IEmployeeRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var Employee = _employeesRepository.GetAll();
            return Ok(Employee);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var Employee = _employeesRepository.GetById(id);
            return Ok(Employee);
        }

        [HttpPost("Save")]
        public IActionResult Post([FromBody] EmployessaddRequests employessAdd)
        {
            Employees employees = new Employees()
            {
                Id = employessAdd.Id,
                HireDate = employessAdd.HireDate,
                CreationDate = employessAdd.CreateDate,
                CreationUser = employessAdd.CreateUser,
                FirstName = employessAdd.firtsName,
                LastName = employessAdd.lastName
            };

            _employeesRepository.Save(employees);
            return Ok();
        }

        [HttpPost("Update")]
        public IActionResult Put([FromBody] Employees employee)
        {
            _employeesRepository.Save(employee);
            return Ok();
        }

        [HttpPost("Remove")]
        public IActionResult Remove([FromBody] Employees employee)
        {
            _employeesRepository.Remove(employee);
            return Ok();
        }
    }
}