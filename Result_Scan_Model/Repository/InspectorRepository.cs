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
    public class InspectorRepository
    {
        private readonly DatabaseContext _context;
        public InspectorRepository(DatabaseContext context) 
        {
            _context = context;
        }

        public InspectorModel GetInspector(string NIK)
        {
            InspectorModel model = new InspectorModel();
            using (SqlConnection conn = _context.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM AspNetUsers WHERE NIK = @NIK", conn);
                cmd.Parameters.AddWithValue("@NIK", NIK);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    model.NIK = reader["NIK"].ToString() ?? string.Empty;
                    model.Name = reader["Name"].ToString() ?? string.Empty;
                    model.PasswordHash = reader["PasswordHash"].ToString() ?? string.Empty;
                }
            }
            return model;
        }
    }
}
