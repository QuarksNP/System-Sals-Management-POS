using itlapr.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace itlapr.DAL.Context
{
    public class ItlaContext : DbContext
    {
        #region"Registros"
        public DbSet<Product> Products { get; set; }
        #endregion""
    }
}
