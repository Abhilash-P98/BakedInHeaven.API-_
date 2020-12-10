using BakedInHeaven.DataAccess.Context;
using BakedInHeaven.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakedInHeaven.DataAccess.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
            private readonly ApplicationDbContext _dbContext;

        public ProductsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    

        public void Add(Product productEntity)
        {
            _dbContext.Products.Add(productEntity);
            _dbContext.SaveChanges();
        }

        public void Delete(Product productEntity)
        {
            _dbContext.Products.Remove(productEntity);
            _dbContext.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        public void Update(Product productEntity)
        {
            _dbContext.Products.Update(productEntity);
            _dbContext.SaveChanges();
        }
    }
}
