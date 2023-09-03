using System;
using System.Collections.Generic;
using System.Text;
using WebService.DataAccessLayer.Context;
using WebService.DataAccessLayer.Repositories.Abstract;
using WebService.Model.Entities;

namespace WebService.DataAccessLayer.Repositories.Concreate.EntityFramework
{
    public class CategoryRepository : GenericRepository<Category, NorthwndContext>, ICategoryRepository
    {
        public List<Category> GetCategories(params string[] includeList)
        {
            return GetAll(filter: null, includeList: includeList);
        }
        public Category GetByCategoryId(int categoryId, params string[] includeList)
        {
            return Get(c => c.CategoryID == categoryId, includeList);
        }
    }
}
