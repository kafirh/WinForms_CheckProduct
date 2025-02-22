using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Result_Scan_Model.Data;
using Result_Scan_Model.Model;

namespace Result_Scan_Model.Repository
{
    public class ResultScanRepository
    {
        private readonly DatabaseContext _context;

        public ResultScanRepository(DatabaseContext context)
        {
            _context = context;
        }

        public List<ResultScanModel> GetAllResultScan()
        {
            List<ResultScanModel> resultScanModels = new List<ResultScanModel>();

            using (SqlConnection conn = _context.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(@"
                    SELECT 
                        r.Id, 
                        r.DateTime, 
                        r.InspectorId, 
                        r.LocationId, 
                        r.ProductId, 
                        r.ModelCodeId, 
                        r.PartMotorWashId, 
                        r.ScanResult, 
                        r.Result,
                        -- Ambil data dari tabel yang berelasi
                        COALESCE(l.LocationName, '') AS LocationName, 
                        COALESCE(p.ProductName, '') AS ProductName,
                        COALESCE(m.ModelNumber, '') AS ModelNumber,
                        COALESCE(pmw.PartNumberId, '') AS PartNumberId,
                        COALESCE(pmw.PartNumber, '') AS PartNumber
                    FROM Result_Scan_Motor_Washes r
                    LEFT JOIN Locations l ON r.LocationId = l.Id
                    LEFT JOIN ProductType p ON r.ProductId = p.Id
                    LEFT JOIN GlobalModelCodes m ON r.ModelCodeId = m.ModelCodeId
                    LEFT JOIN Part_Motor_Washes pmw ON r.PartMotorWashId = pmw.PartNumberId;
                ", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            resultScanModels.Add(new ResultScanModel
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                DateTime = Convert.ToDateTime(reader["DateTime"]),
                                InspectorId = reader["InspectorId"]?.ToString() ?? string.Empty,
                                LocationId = reader["LocationId"] != DBNull.Value ? Convert.ToInt32(reader["LocationId"]) : 0,
                                ProductId = reader["ProductId"] != DBNull.Value ? Convert.ToInt32(reader["ProductId"]) : 0,
                                ModelCodeId = reader["ModelCodeId"]?.ToString() ?? string.Empty,
                                PartMotorWashId = reader["PartMotorWashId"]?.ToString() ?? string.Empty,
                                ScanResult = reader["ScanResult"]?.ToString() ?? string.Empty,
                                Result = reader["Result"]?.ToString() ?? string.Empty,

                                // Ambil data langsung dari hasil query JOIN
                                Location = new LocationModel
                                {
                                    Id = reader["LocationId"] != DBNull.Value ? Convert.ToInt32(reader["LocationId"]) : 0,
                                    LocationName = reader["LocationName"]?.ToString() ?? string.Empty
                                },
                                ProductType = new ProductTypeModel
                                {
                                    Id = reader["ProductId"] != DBNull.Value ? Convert.ToInt32(reader["ProductId"]) : 0,
                                    ProductName = reader["ProductName"]?.ToString() ?? string.Empty
                                },
                                ModelCode = new ModelCodeModel
                                {
                                    ModelCodeId = reader["ModelCodeId"]?.ToString() ?? string.Empty,
                                    ModelNumber = reader["ModelNumber"]?.ToString() ?? string.Empty
                                },
                                PartMotorWash = new PartMotorWashModel
                                {
                                    PartNumberId = reader["PartNumberId"]?.ToString() ?? string.Empty,
                                    PartNumber = reader["PartNumber"]?.ToString() ?? string.Empty
                                }
                            });
                        }
                    }
                }
            }

            return resultScanModels;
        }
    }
}
