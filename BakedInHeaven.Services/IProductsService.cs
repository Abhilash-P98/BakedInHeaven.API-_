using BakedInHeaven.BusinessServices.Dto;
using BakedInHeaven.DataAccess.Entities;
using System.Collections.Generic;

namespace BakedInHeaven.BusinessServices
{
    public interface IProductsService
    {
        IEnumerable<ProductDto> GetAllProducts();
        void AddProduct(ProductDto product);
        void DeleteProduct(ProductDto product);
        void UpdateProduct(ProductDto product);
    }
}