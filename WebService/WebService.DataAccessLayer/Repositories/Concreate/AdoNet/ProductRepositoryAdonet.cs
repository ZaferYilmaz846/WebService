using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using WebService.DataAccessLayer.Repositories.Abstract;
using WebService.Model.Entities;

namespace WebService.DataAccessLayer.Repositories.Concreate.AdoNet
{
    public class ProductRepositoryAdonet : IProductRepository
    {
        public List<Product> GetByCategoryId(int categoryId, params string[] includeList)
        {
            throw new NotImplementedException();
        }

        public Product GetByProductId(int productId, params string[] includeList)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByPrice(int minPrice, int maxPrice, params string[] includeList)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts(params string[] includeList)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-0LOVGSG;Database=NORTHWND;Trusted_Connection=True;";
            SqlCommand command = new SqlCommand("Select ProductId,ProductName,UnitPrice from Products");
            command.Connection = con;
            List<Product> list = new List<Product>();
            con.Open();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Product()
                {
                    ProductID = Convert.ToInt32(dr["ProductId"]),
                    ProductName = dr["ProductName"].ToString(),
                    UnitPrice = Convert.ToDecimal(dr["UnitPrice"].ToString())
                });
            }

            con.Close();
            return list;
        }
    }
}
