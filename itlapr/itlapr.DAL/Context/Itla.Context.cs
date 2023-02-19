using Microsoft.EntityFrameworkCore;
using itlapr.DAL.Entities;

namespace itlapr.DAL.Context
{
    public class ItlaContext : DbContext
    {
        #region"Registros"
        public DbSet<Product> Products { get; set; }
        #endregion""
    }
}
