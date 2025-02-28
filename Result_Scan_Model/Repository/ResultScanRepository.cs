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
        private static ResultScanRepository _instance;
        private static readonly object _lock = new object();
        private readonly DatabaseContext _context;

        // Constructor private agar tidak bisa diinstansiasi langsung
        private ResultScanRepository()
        {
            _context = new DatabaseContext();
        }

        // Properti untuk mendapatkan instance tunggal
        public static ResultScanRepository Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ResultScanRepository();
                    }
                    return _instance;
                }
            }
        }

        public List<ResultScanModel> GetAllResultScan(DateTime date, string modelCodeId, int locationId)
        {
            List<ResultScanModel> resultScanModels = new List<ResultScanModel>();
            date = date.Date;
            using (SqlConnection conn = _context.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(@"
                   WITH FilteredResults AS (
                        SELECT 
                            Id, 
                            DateTime, 
                            InspectorId, 
                            LocationId, 
                            ProductId, 
                            ModelCodeId, 
                            PartMotorWashId, 
                            ScanResult, 
                            Result
                        FROM Result_Scan_Motor_Washes
                        WHERE CAST(DateTime AS DATE) = @Date
                            AND (@ModelCodeId = '' OR ModelCodeId = @ModelCodeId)
                            AND LocationId = @LocationId
                    )
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
                        COALESCE(l.LocationName, '') AS LocationName, 
                        COALESCE(p.ProductName, '') AS ProductName,
                        COALESCE(m.ModelNumber, '') AS ModelNumber,
                        COALESCE(pmw.PartNumberId, '') AS PartNumberId,
                        COALESCE(pmw.PartNumber, '') AS PartNumber
                    FROM FilteredResults r
                    LEFT JOIN Locations l ON r.LocationId = l.Id
                    LEFT JOIN ProductType p ON r.ProductId = p.Id
                    LEFT JOIN GlobalModelCodes m ON r.ModelCodeId = m.ModelCodeId
                    LEFT JOIN Part_Motor_Washes pmw ON r.PartMotorWashId = pmw.PartNumberId;
                ", conn))
                {
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@ModelCodeId", modelCodeId);
                    cmd.Parameters.AddWithValue("LocationId", locationId);
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
        public event Action DataUpdated;

        public bool Add(ResultScanModel resultScan)
        {
            using (SqlConnection conn = _context.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(@"
            INSERT INTO Result_Scan_Motor_Washes 
            (DateTime, InspectorId, LocationId, ProductId, ModelCodeId, PartMotorWashId, ScanResult, Result) 
            VALUES 
            (@DateTime, @InspectorId, @LocationId, @ProductId, @ModelCodeId, @PartMotorWashId, @ScanResult, @Result);
        ", conn))
                {
                    // Tambahkan parameter untuk mencegah SQL Injection
                    cmd.Parameters.AddWithValue("@DateTime", resultScan.DateTime);
                    cmd.Parameters.AddWithValue("@InspectorId", resultScan.InspectorId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@LocationId", resultScan.LocationId != 0 ? resultScan.LocationId : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ProductId", resultScan.ProductId != 0 ? resultScan.ProductId : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ModelCodeId", string.IsNullOrEmpty(resultScan.ModelCodeId) ? (object)DBNull.Value : resultScan.ModelCodeId);
                    cmd.Parameters.AddWithValue("@PartMotorWashId", string.IsNullOrEmpty(resultScan.PartMotorWashId) ? (object)DBNull.Value : resultScan.PartMotorWashId);
                    cmd.Parameters.AddWithValue("@ScanResult", resultScan.ScanResult ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Result", resultScan.Result ?? (object)DBNull.Value);

                    int rowsAffected = cmd.ExecuteNonQuery(); // Eksekusi query
                    if (rowsAffected > 0)
                    {
                        DataUpdated?.Invoke(); // Trigger event jika insert sukses
                    }
                    return rowsAffected > 0; // Jika lebih dari 0 berarti berhasil insert
                }
            }
        }
    }
}
