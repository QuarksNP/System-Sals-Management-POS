using DocumentFormat.OpenXml.Bibliography;
using itla.API.Requests;
using itlapr.DAL.Core;
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

        [HttpGet()]
        public IEnumerable<Product> Get()
        {
            return this.productRepository.GetEntities();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = this.productRepository.GetEntity(id);
            return Ok(product);
        }

        [HttpPost("Save")]
        public void Post([FromBody] ProductAddRequest productAdd)
        {
            Product product = new Product();
            {
                string ProductName = productAdd.ProductName,
                       Description = productAdd.Description;
                int    CreateUser = productAdd.CreateUser;
                DateTime CreateDate = productAdd.CreateDate;


            };
            this.productRepository.Save(product);
        }


        [HttpPost("Update")]
        public void Put([FromBody] ProductUpdateRequest productUpdate)
        {
            Product product = new Product();
            {
                int ProductId = productUpdate.ProductId;
                string ProductName = productUpdate.ProductName, 
                       Category = productUpdate.Category;

            }
            this.productRepository.Update(product);
        }

        [HttpPost("Remove")]
        public void Remove([FromBody]ProductRemoveRequest productRemove)
        {
            Product product = new Product();
            {
                int ProductId = productRemove.ProductId;
                string ProductName = productRemove.ProductName,
                 Description = productRemove.Description,
                 Category = productRemove.Category;
            }
            this.productRepository.Remove(product);
        }
    }
}