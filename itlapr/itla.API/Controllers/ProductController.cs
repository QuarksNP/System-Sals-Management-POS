using itlapr.DAL.Entities;
using itlapr.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
    

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ItlaApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        // GET: api/<ProductController>
        [HttpGet()]
        public IEnumerable<Product> Get()
        {
           return this.productRepository.GetAl1();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = this.productRepository.GetById(id);
            return Ok(product);
        }

        [HttpPost("Save")]
        public void Post([FromBody] Product product)
        {
            this.productRepository.Save(product);
        }


        [HttpPost("Update")]
        public void Put( Product product)
        {
            this.productRepository.Update(product);
        }

        [HttpPost("Remove")]
        public void Remove(Product product)
        {
            this.productRepository.Remove(product);
        }
    }
}