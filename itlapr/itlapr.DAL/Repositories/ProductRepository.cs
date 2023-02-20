using System.Collections.Generic;
using itlapr.DAL.Entities;
using itlapr.DAL.Context;
using System.Linq;
using itlapr.DAL.Core;

namespace itlapr.DAL.Repositories
{
    public class ProductRepository : Interfaces.IProductRepository
    {
        private readonly ItlaContext ItlaContext;
        private readonly ILogger<ProductRepository> Logger;
        public ProductRepository(ItlaContext ItlaContext, ILogger<ProductRepository> logger)
        {
            this.ItlaContext = ItlaContext;
            this.Logger = logger;
        }
        public bool Exists(string name)
        {
            return this.ItlaContext.Products.Any(st => st.productname == name);
        }

        public List<Product> GetAl1()
        {
            return this.ItlaContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            return this.ItlaContext.Products.Find();
        }

        public void Remove(Product product)
        {
            try
            {
                Product productToRemove = this.GetById(product.ProductId);

                productToRemove.Deleted = true;
                productToRemove.DeletedDate = DateTime.Now;
                productToRemove.UserDeleted = product.UserDeleted;

                this.ItlaContext.Products.Update(productToRemove);
                this.ItlaContext.SaveChanges();
            }
            catch (Exception ex)
            {
                this.Logger.logError($"Error removiendo el Producto", ex.ToString());
            }
        }

        public void Save(Product product)
        {
            try
            {
                Product productToAdd = new Product()
                {
                    productname = product.productname,
                    categoryname = product.categoryname,
                    CreationDate = product.CreationDate,
                    CreationUser = product.CreationUser,
                    Description = product.Description,
                };
                this.ItlaContext.Products.Add(productToAdd);
                this.ItlaContext.SaveChanges();
            }
            catch (Exception ex)
            {
                this.Logger.logError($"Error removiendo el Producto", ex.ToString());
                throw;
            }
        }

        public void Update(Product product)
        {
            try
            {
                Product productToUpdate = this.GetById(product.ProductId);
                productToUpdate.productname = product.productname;
                productToUpdate.categoryname = product.categoryname;
                productToUpdate.CreationDate = DateTime.Now;
                productToUpdate.CreationUser = product.CreationUser;
                productToUpdate.Description = product.Description;

                this.ItlaContext.SaveChanges();
            }
            catch (Exception ex)
            {
                this.Logger.logError($"Error removiendo el producto", ex.ToString());
            }

        }
    }
}
