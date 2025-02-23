using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Result_Scan_Model.Data;
using Result_Scan_Model.Model;

namespace Result_Scan_Model.Repository
{
    public class ProductTypeRepository
    {
        private readonly DatabaseContext _context;

        public ProductTypeRepository(DatabaseContext context)
        {
            _context = context;
        }

        public List<ProductTypeModel> GetAllProduct()
        {
            List<ProductTypeModel> productTypeModels = new List<ProductTypeModel>();
            using (SqlConnection conn = _context.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProductType", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    productTypeModels.Add(new ProductTypeModel
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        ProductName = reader["ProductName"].ToString(),
                    });
                }
            }
            return productTypeModels;
        }

        public ProductTypeModel GetProduct(int id)
        {
            using (SqlConnection conn = _context.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProductType WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ProductTypeModel product = new ProductTypeModel
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        ProductName = reader["ProductName"].ToString()
                    };
                    return product;
                }
            }
            return new ProductTypeModel();
        }
    }
}
