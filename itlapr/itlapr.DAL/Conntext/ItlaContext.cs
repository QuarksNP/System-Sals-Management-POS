
using itlapr.DAL.Entities;
using itlapr.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace itlapr.DAL.Context
{
    public class ItlaContext : DbContext
    {
        public ItlaContext()
        {

        }

        public ItlaContext(DbContextOptions<ItlaContext> options) : base(options)
        {

        }

        #region "Registros"
        public DbSet<Employees> Employee { get; set; }
        public DbSet<Department> Departments { get; set; }
        #endregion
    }
}
