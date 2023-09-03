using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebService.BusinessLayer.Abstract;
using WebService.BusinessLayer.Concreate;
using WebService.Model.Entities;

namespace WebService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryBL cl;
        public CategoryController(ICategoryBL _cl)
        {
            cl = _cl;
        }
        [HttpGet("getall")]
        public List<Category> GetCategories()
        {
            var categories = cl.GetCategories();
            return categories;
        }   
        [HttpGet("getbyid")]
        public Category GetByCategoryId(int categoryId)
        {
            var categories = cl.GetByCategoryId(categoryId);
            return categories;
        }
    }
}
