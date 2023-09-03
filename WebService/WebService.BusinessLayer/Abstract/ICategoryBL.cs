using System;
using System.Collections.Generic;
using System.Text;
using WebService.Model.Entities;

namespace WebService.BusinessLayer.Abstract
{
    public interface ICategoryBL
    {
        List<Category> GetCategories(params string[] includeList);
        Category GetByCategoryId(int categoryId, params string[] includeList);
    }
}
