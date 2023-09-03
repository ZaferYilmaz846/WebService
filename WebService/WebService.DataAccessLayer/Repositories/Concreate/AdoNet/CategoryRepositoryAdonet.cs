using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using WebService.DataAccessLayer.Repositories.Abstract;
using WebService.Model.Entities;

namespace WebService.DataAccessLayer.Repositories.Concreate.AdoNet
{
    public class CategoryRepositoryAdonet : ICategoryRepository
    {
        public Category GetByCategoryId(int categoryId, params string[] includeList)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories(params string[] includeList)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=DESKTOP-0LOVGSG;Database=NORTHWND;Trusted_Connection=True;";
            SqlCommand command = new SqlCommand("Select CategoryId, CategoryName from Categories");
            command.Connection = con;
            List<Category> list = new List<Category>();
            con.Open();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Category()
                {
                    CategoryID = Convert.ToInt32(dr["CategoryId"]),
                    CategoryName = dr["CategoryName"].ToString()
                });
            }

            con.Close();
            return list;
        }
    }
}
