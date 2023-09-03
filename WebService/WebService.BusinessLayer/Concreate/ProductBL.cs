using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using WebService.BusinessLayer.Abstract;
using WebService.DataAccessLayer.Repositories.Abstract;
using WebService.DataAccessLayer.Repositories.Concreate;
using WebService.Model.Entities;

namespace WebService.BusinessLayer.Concreate
{
    public class ProductBL : IProductBL
    {
        private IProductRepository pr;
        public ProductBL(IProductRepository _pr)
        {
            pr = _pr;
        }
        public List<Product> GetProducts(params string[] includeList)
        {
            var products = pr.GetProducts(includeList: includeList);
            return products;
        }
        public List<Product> GetProductByPrice(int minPrice, int maxPrice, params string[] includeList)
        {
            var products = pr.GetProductByPrice(minPrice, maxPrice, includeList);
            return products;
        }
        public Product GetByProductId(int productId, params string[] includeList)
        {
            var products = pr.GetByProductId(productId, includeList);
            return products;
        }
    }
}
