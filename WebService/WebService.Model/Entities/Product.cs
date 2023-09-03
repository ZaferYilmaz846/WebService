using Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebService.Model.Entities
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Category Category { get; set; }
    }
}
