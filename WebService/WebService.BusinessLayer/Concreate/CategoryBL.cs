using System;
using System.Collections.Generic;
using System.Text;
using WebService.BusinessLayer.Abstract;
using WebService.DataAccessLayer.Repositories.Abstract;
using WebService.DataAccessLayer.Repositories.Concreate;
using WebService.Model.Entities;

namespace WebService.BusinessLayer.Concreate
{
    public class CategoryBL : ICategoryBL
    {
        private ICategoryRepository cr;
        public CategoryBL(ICategoryRepository _cr)
        {
            cr = _cr;
        }
        public List<Category> GetCategories(params string[] includeList)
        {
            var categories = cr.GetCategories(includeList:includeList);
            return categories;
        }
        public Category GetByCategoryId(int categoryId, params string[] includeList)
        {
            var categories = cr.GetByCategoryId(categoryId, includeList);
            return categories;
        }
    }
}
