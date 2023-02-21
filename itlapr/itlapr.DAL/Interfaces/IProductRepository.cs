using itlapr.DAL.Entities;
using System.Collections.Generic;



namespace itlapr.DAL.Interfaces
{
    public interface IProductRepository
    {
        void Save(Product product);

        void Update(Product product);

        void Remove(Product product);

        Product GetById(int productId);

        List<Product> GetAl1();

        bool Exists(string name);
        void Remove(object product);
    }
}

