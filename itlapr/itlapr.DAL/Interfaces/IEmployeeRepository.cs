using itlapr.DAL.Entity;

namespace itlapr.DAL.Interfaces
{
    public interface IEmployeeRepository
    {
        void Save(Employees employee);
        void Update(Employees employee);
        void Remove(Employees employee);

        Employees GetById(int employeeId);

        List<Employees> GetAll();

        bool Exists(string name);
    }
}
