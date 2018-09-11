using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheImplementation
{
    class Database : IRepository
    {
        List<Product> IRepository.GetAllProducts()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=NewProduct;User ID=Sa;Password=test123!@#";
            SqlCommand command = new SqlCommand("SELECT * FROM Product", connection);
            command.CommandType = System.Data.CommandType.Text;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            dataAdapter.Fill(dataTable);
            connection.Close();
            List<Product> products = new List<Product>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                products.Add(
                    new Product
                    {
                        id = Convert.ToInt32(dataRow["Id"]),
                        name = Convert.ToString(dataRow["Name"]),

                    }
                );
            }
            return products;
        }

        Product IRepository.GetById(int id)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=.;Initial Catalog=NewProduct;User ID=Sa;Password=test123!@#";
            SqlCommand command = new SqlCommand("SELECT * FROM Product where Id=" + id, connection);
            command.CommandType = System.Data.CommandType.Text;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            connection.Open();
            dataAdapter.Fill(dataTable);
            connection.Close();
            List<Product> products = new List<Product>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                products.Add(
                    new Product
                    {
                        id = Convert.ToInt32(dataRow["Id"]),
                        name = Convert.ToString(dataRow["Name"]),

                    }
                );
            }
            return products[0];
        }
    }
}
