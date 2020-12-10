using BakedInHeaven.DataAccess.Entities;
using System.Collections.Generic;

namespace BakedInHeaven.DataAccess.Repositories
{
    public interface IProductsRepository
    {
        List<Product> GetAllProducts();
        void Add(Product productEntity);
        void Delete(Product productEntity);

        void Update(Product productEntity);
    }
}