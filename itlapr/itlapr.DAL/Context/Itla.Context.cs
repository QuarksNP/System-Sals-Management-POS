using Microsoft.EntityFrameworkCore;
using itlapr.DAL.Entities;

namespace itlapr.DAL.Context
{
    public class ItlaContext : DbContext
    {
        #region"Registros"
        public DbSet<Product> products{ get; set; }
        #endregion""
    }
}
