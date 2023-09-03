using System;
using System.Collections.Generic;
using System.Text;
using WebService.Model.Entities;

namespace WebService.BusinessLayer.Abstract
{
    public interface IProductBL
    {
        List<Product> GetProducts(params string[] includeList);
        List<Product> GetProductByPrice(int minPrice, int maxPrice, params string[] includeList);
        Product GetByProductId(int productId, params string[] includeList);
    }
}
