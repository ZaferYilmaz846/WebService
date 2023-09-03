using System;
using System.Collections.Generic;
using System.Text;
using WebService.Model.Entities;

namespace WebService.DataAccessLayer.Repositories.Abstract
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories(params string[] includeList);
        Category GetByCategoryId(int categoryId, params string[] includeList);
    }
}
