using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebService.BusinessLayer.Abstract;
using WebService.BusinessLayer.Concreate;
using WebService.DataAccessLayer.Repositories.Concreate;
using WebService.Model.Entities;

namespace WebService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductBL pl;
        public ProductController(IProductBL _pl)
        {
            pl = _pl;
        }
        [HttpGet("getall")]
        public List<Product> GetProducts()
        {
            var products = pl.GetProducts("Category");
            return products;
        }
        [HttpGet("getbyid")]
        public Product GetByProductId(int productId)
        {
            var products = pl.GetByProductId(productId);
            return products;
        }
        [HttpGet("getproductbyprice")]
        public List<Product> GetProductByPrice(int min, int max)
        {
            var products = pl.GetProductByPrice(min, max);
            return products;
        }
    }
}
