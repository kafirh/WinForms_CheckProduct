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
    public class ScanPartRepository
    {
        private readonly DatabaseContext _context;

        public ScanPartRepository(DatabaseContext context)
        {
            _context = context;
        }

        public ScanPartModel GetScanPart(string modelCodeId)
        {
            ScanPartModel model = null;
            using (SqlConnection conn = _context.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Scan_Parts WHERE ModelCodeId = @ModelCodeId", conn);
                cmd.Parameters.AddWithValue("@ModelCodeId", modelCodeId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    model = new ScanPartModel
                    {
                        ModelCodeId = reader["ModelCodeId"].ToString(),
                        MotorWashNumberId = reader["MotorWashNumberId"].ToString()
                    };
                }
            }
            return model;

        }
    }
}
