using System.Collections.Generic;
using itlapr.DAL.Entities;


namespace itlapr.DAL.Interfaces
{
    public interface IDepartmentRepository
    {

        List<Department> GetAll();

        void Save(Department department);

        void Update(Department department);

        void Remove(Department department);

        Department Get(int id);

        bool Exists(string Name);
    }
}