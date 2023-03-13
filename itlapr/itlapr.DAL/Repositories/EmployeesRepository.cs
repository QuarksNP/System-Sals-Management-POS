using itlapr.DAL.Entity;
using itlapr.DAL.Context;
using Microsoft.Extensions.Logging;
using itlapr.DAL.Interfaces;
using itlapr.DAL.Core;
namespace itlapr.DAL.Repositories
{
    public class EmployeesRepository :RepositoryBase<Employees>, IEmployeeRepository
    {
        private readonly ItlaContext itlaContext;
        private readonly ILogger<EmployeesRepository> logger;

        public EmployeesRepository(ItlaContext itlaContext, ILogger<EmployeesRepository> logger) : base(itlaContext)
        {
            this.itlaContext = itlaContext;
            this.logger = logger;
        }

        public override void Save(Employees entity)
        {
          base.Save(entity);
          base.SaveChanges();
        }

        public override void Update(Employees entity)
        {
            base.Update(entity);
            base.SaveChanges();
        }

        public override void Remove(Employees entity)
        {
            base.Remove(entity);
            base.SaveChanges();

        }

        public override List<Employees> GetEntities()
        {
            return this.itlaContext.Employee.ToList();
        }

        public override Employees GetEntity(int id)
        {
            return this.itlaContext.Employee.FirstOrDefault(em => em.empId == id);
        }


    }
}
