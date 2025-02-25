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
    public class PartMotorWashRepository
    {
        private readonly DatabaseContext _context;

        public PartMotorWashRepository(DatabaseContext context)
        {
            _context = context;
        }

        public PartMotorWashModel GetPartMotorWash(string partNumberId)
        {
            PartMotorWashModel model = new PartMotorWashModel();
            using (SqlConnection conn = _context.GetConnection())
            {
                conn.Open(); 
                SqlCommand cmd = new SqlCommand("SELECT * FROM Part_Motor_Washes WHERE PartNumberId = @PartNumberId", conn);
                cmd.Parameters.AddWithValue("@PartNumberId", partNumberId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    model = new PartMotorWashModel
                    {
                        PartNumberId = reader["PartNumberId"].ToString(),
                        PartNumber = reader["PartNumber"].ToString()
                    };
                }
            }
            return model;

        }
    }
}
