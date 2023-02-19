using System.Collections.Generic;
using itlapr.DAL.Entities;
using itlapr.DAL.Context;
using System.Linq;
using itlapr.DAL.Core;

namespace itlapr.DAL.Repositories
{
    public class ProductRepository : Interfaces.IProductRepository
    {
        private readonly ItlaContext itlaContext;
        private readonly ILogger<ProductRepository> Logger;
        public ProductRepository(ItlaContext itlaContext,
                                 ILogger<ProductRepository> logger)
        {
            this.itlaContext = itlaContext;
            this.Logger = logger;
        }
        public bool Exists(string name)
        {
            return this.itlaContext.Products.any(st => st.Firtname == name);
        }

        public List<Product> GetAl1()
        {
            return this.itlaContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            return this.itlaContext.Products.Find(ProductId);
        }

        public void Remove(Product product)
        {
            try
            {
                Product productToRemove = this.GetById(product.ProductId);

                productToRemove.Deleted = true;
                productToRemove.DeletedDate = DateTime.Now;
                productToRemove.UserDeleted = product.UserDeleted;

                this.itlaContext.Products.update(productToRemove);
                this.itlaContext.SaveChanges();
            }
            catch (Exception ex)
            {
                this.Logger.logError($"Error removiendo el producto", ex ToString());
            }
        }

        public void Save(Product product)
        {
            try
            {
                Product productToAdd = new Product();
                {
                    FirsName = product.FirtName,
                    LastName = product.Lastname,
                    CreationDate = DataTime.now,
                    CreationUser = product.DataTime.Now,
                        EnrollmentDate = product.EnrollmentDate
                };
                this.itlaContext.Products.Add(productToAdd);
                this.itlaContext.SaveChanges();
            }
            catch (Exception ex)
            {
                this.Logger.logError($"Error removiendo el producto", ex ToString());
            }
        }

        public void Update(Product product)
        {
            try
            {
                Product productToUpdate = this.GetById(product.ProductId);

                productToUpdate.FirsName = product.FirtName,
                        productToUpdate.LastName = product.Lastname,
                         productToUpdate.EnrollmentDate = product.EnrollmentDate
                        productToUpdate.ModifyDate = DataTime.Now;
                productToUpdate.UserMod = product.UserMod.Now;

                this.itlaContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }

        }
    }
}
