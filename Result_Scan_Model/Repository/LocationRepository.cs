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
    public class LocationRepository
    {
        private readonly DatabaseContext _context;

        public LocationRepository(DatabaseContext context)
        {
            _context = context;
        }

        public List<LocationModel> GetAllLocation()
        {
            List<LocationModel> locationModels = new List<LocationModel>();
            using (SqlConnection conn = _context.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Locations", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    locationModels.Add(new LocationModel
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        LocationName = reader["LocationName"].ToString(),
                    });
                }
            }
            return locationModels;
        }

        public LocationModel GetLocation(int id)
        {
            using (SqlConnection conn = _context.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Locations WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    LocationModel location = new LocationModel
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        LocationName = reader["LocationName"].ToString()
                    };
                    return location;
                }
            }
            return null;
        }
    }
}
