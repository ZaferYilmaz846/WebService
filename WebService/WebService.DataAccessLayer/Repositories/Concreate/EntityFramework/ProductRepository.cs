using System;
using System.Collections.Generic;
using System.Text;
using WebService.DataAccessLayer.Context;
using WebService.DataAccessLayer.Repositories.Abstract;
using WebService.Model.Entities;

namespace WebService.DataAccessLayer.Repositories.Concreate.EntityFramework
{
    public class ProductRepository : GenericRepository<Product, NorthwndContext>, IProductRepository
    {
        public List<Product> GetProducts(params string[] includeList)
        {
            return GetAll(filter: null, includeList: includeList);
        }
        public List<Product> GetProductByPrice(int minPrice, int maxPrice, params string[] includeList)
        {
            return GetAll(p => p.UnitPrice > minPrice && p.UnitPrice < maxPrice, includeList);
        }
        public List<Product> GetByCategoryId(int categoryId, params string[] includeList)
        {
            return GetAll(p => p.CategoryID == categoryId, includeList);
        }
        public Product GetByProductId(int productId, params string[] includeList)
        {
            return Get(p => p.ProductID == productId, includeList);
        }

    }
}
