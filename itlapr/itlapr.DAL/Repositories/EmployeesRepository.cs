using itlapr.DAL.Entity;
using itlapr.DAL.Context;
using Microsoft.Extensions.Logging;


namespace itlapr.DAL.Repositories
{
    public class EmployeesRepository : Interfaces.IEmployeeRepository
    {
        private readonly ItlaContext itlaContext;
        private readonly ILogger<EmployeesRepository> logger;

        public EmployeesRepository(ItlaContext itlaContext, ILogger<EmployeesRepository> logger) 
        {
            this.itlaContext = itlaContext;
            this.logger = logger;
        }
        public bool Exists(string name)
        {
            return this.itlaContext.Employee.Any(st => st.FirstName == name);
        }

        public List<Employees> GetAll()
        {
            return this.itlaContext.Employee.ToList();
        }

        public Employees GetById(int employeeId)
        {
            return this.itlaContext.Employee.Find();
        }

        public void Remove(Employees employee)
        {
            try
            {
                Employees employeeToRemove = this.GetById(employee.Id);
                
                employeeToRemove.Deleted= true;
                employeeToRemove.DeleteDate = DateTime.Now;
                employeeToRemove.UserDeleted = employee.UserDeleted;

                this.itlaContext.Employee.Update(employeeToRemove);
                this.itlaContext.SaveChanges();
            }

            catch(Exception ex)
            {
                this.logger.LogError($"Error deleting the employee", ex.ToString());
            }
        }

        public void Save(Employees employee)
        {
            try
            {
                Employees employeeToAdd = new Employees()
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    CreationDate = DateTime.Now,
                    CreationUser = employee.CreationUser,
                    HireDate = employee.HireDate

                };

                this.itlaContext.Employee.Add(employeeToAdd);
                this.itlaContext.SaveChanges();
                
            }

            catch(Exception ex)
            {

            }
        }

        public void Update(Employees employee)
        {
            try
            {
                Employees employeeToUpdate = this.GetById(employee.Id);
                
                employeeToUpdate.FirstName = employee.FirstName;
                employeeToUpdate.LastName = employee.LastName;
                employeeToUpdate.ModifyDate = DateTime.Now;
                employeeToUpdate.UserMod = employee.UserMod;
                employeeToUpdate.HireDate= employee.HireDate;

                this.itlaContext.SaveChanges();


            }

            catch (Exception ex)
            {

            }
        }
    }
}
