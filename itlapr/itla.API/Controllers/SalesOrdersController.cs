using itlapr.DAL.Entities;
using itlapr.DAL.Interfaces;
using itlapr.DAL.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace itla.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrdersController : ControllerBase
    {
        private readonly ISalesOrdersRepository salesOrdersRepository;

        public SalesOrdersController(ISalesOrdersRepository salesOrdersRepository)
        {
            this.salesOrdersRepository = salesOrdersRepository;
        }

        [HttpGet]
        public IEnumerable<SalesOrders> Get()
        {
            return this.salesOrdersRepository.GetAll();
        }

        public SalesOrders Get(int id)
        {
            return this.salesOrdersRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] SalesOrders salesOrders)
        {
            this.salesOrdersRepository.Save(salesOrders);
        }

        [HttpPost]
        public void Put(SalesOrders salesOrders)
        {
            this.salesOrdersRepository.Update(salesOrders);
        }

        [HttpPost]
        public void Delete(SalesOrders salesOrders)
        {
            this.salesOrdersRepository.Remove(salesOrders);
        }
    }
}
