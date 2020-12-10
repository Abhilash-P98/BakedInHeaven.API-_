using BakedInHeaven.BusinessServices.Dto;
using BakedInHeaven.DataAccess.Entities;
using BakedInHeaven.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakedInHeaven.BusinessServices
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }
        public void AddProduct(ProductDto product)
        {
            var productEntity = new Product
            {
                Id = product.Id,
                IsVeg = product.IsVeg,
                Kcal = product.Kcal,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                WeightInGrams = product.WeightInGrams

            };
            List<Product> data = new List<Product>();
            data = _productsRepository.GetAllProducts();
            productEntity.AvailableDate = product.AvailableDate;
            productEntity.IsSpecial = product.IsSpecial;
            int Total = data.Where(x => x.AvailableDate == product.AvailableDate).Count();
            int Count = data.Where(x => x.IsSpecial == product.IsSpecial).Count();
            if (Total < 15)
                {
                if (Count < 4)
                {
                    _productsRepository.Add(productEntity);
                }
            }
             

        }
        public void DeleteProduct(ProductDto product)
        {
            var productEntity = new Product
            {
                AvailableDate = product.AvailableDate,
                Id = product.Id,
                IsSpecial = product.IsSpecial,
                IsVeg = product.IsVeg,
                Kcal = product.Kcal,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                WeightInGrams = product.WeightInGrams

            };
            _productsRepository.Delete(productEntity);

        }
        public void UpdateProduct(ProductDto product)
        {
            var productEntity = new Product
            {
                AvailableDate = product.AvailableDate,
                Id = product.Id,
                IsSpecial = product.IsSpecial,
                IsVeg = product.IsVeg,
                Kcal = product.Kcal,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                WeightInGrams = product.WeightInGrams

            };
            _productsRepository.Update(productEntity);

        }
        public IEnumerable<ProductDto> GetAllProducts()
        {

            var products = _productsRepository.GetAllProducts();

            return products.Select(p => new ProductDto
            {
                AvailableDate = p.AvailableDate,
                Id = p.Id,
                IsSpecial = p.IsSpecial,
                IsVeg = p.IsVeg,
                Kcal = p.Kcal,
                Price = p.Price,
                Quantity = p.Quantity,
                Name = p.Name,
                WeightInGrams = p.WeightInGrams
            });
        }
    }
}
