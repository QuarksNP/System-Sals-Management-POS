using itlapr.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace itlapr.DAL.Context
{
    public class ItlaContext : DbContext
    {

        public ItlaContext(DbContextOptions<ItlaContext> options) : base(options)
        {
            
        }


        #region"Registros"
        public DbSet<Product> Products { get; set; }
        #endregion""    
    }
}
