using itlapr.DAL.Entities;
using System.Collections.Generic;

namespace itlapr.DAL.Interfaces
{
    public interface ISalesOrdersRepository
    {
        void Save(SalesOrders salesOrders);
        void Update(SalesOrders salesOrders);
        void Remove(SalesOrders salesOrders);
        SalesOrders GetById(int shipperid);
        List<SalesOrders> GetAll();
        bool Exists(string name);
    }
}