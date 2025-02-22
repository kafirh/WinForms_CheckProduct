using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Result_Scan_Model.Data;
using Result_Scan_Model.Model;
using Result_Scan_Model.Repository;

namespace Result_Scan_Model.Repository
{
    public class ModelCodeRepository : IModelCodeRepository
    {
        private readonly DatabaseContext _context;

        public ModelCodeRepository(DatabaseContext context)
        {
            _context = context;
        }

        public List<ModelCodeModel> GetAllModelCodes()
        {
            List<ModelCodeModel> modelCodes = new List<ModelCodeModel>();
            using (SqlConnection conn = _context.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM GlobalModelCodes", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    modelCodes.Add(new ModelCodeModel
                    {
                        ModelCodeId = reader["ModelCodeId"].ToString(),
                        ModelNumber = reader["ModelNumber"].ToString(),
                    });
                }
            }
            return modelCodes;
        }

        public ModelCodeModel GetModelCode(string modelCodeId)
        {
            ModelCodeModel modelCode = null;
            using (SqlConnection conn = _context.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM GlobalModelCodes WHERE ModelCodeId = @ModelCodeId", conn);
                cmd.Parameters.AddWithValue("@ModelCodeId", modelCodeId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    modelCode = new ModelCodeModel
                    {
                        ModelCodeId = reader["ModelCodeId"].ToString(),
                        ModelNumber = reader["ModelNumber"].ToString()
                    };
                }
            }
            return modelCode;
        }
    }
}
