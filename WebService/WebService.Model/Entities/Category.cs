using Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebService.Model.Entities
{
    public class Category : IEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
