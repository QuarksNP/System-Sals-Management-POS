using itlapr.DAL.Context;
using itlapr.DAL.Entities;
using itlapr.DAL.Interfaces;    
using Microsoft.Extensions.Logging;

namespace itlathApp.DAL.Repositories
{
    public class ProductRepository : Core.RepositoryBase<Product>, IProductRepository
    {
        private readonly ItlaContext context;
        private readonly ILogger<ProductRepository> ilogger;

        public ProductRepository(ItlaContext context,
                                    ILogger<ProductRepository> ilogger) : base(context)
        {
            this.context = context;
            this.ilogger = ilogger;
        }
        public override List<Product> GetEntities()
        {
            return this.context.Products
                               .Where(de => !de.Deleted)
                               .OrderByDescending(cd => cd.CreationDate).ToList();
        }

    }
}