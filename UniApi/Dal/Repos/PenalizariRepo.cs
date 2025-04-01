using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class PenalizariRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public PenalizariInfo PenalizariGet(long id)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand("PenalizariGet", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Penalizari", id);

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new PenalizariInfo
                            {
                                Id = id,
                                Procent = (decimal)reader["Procent"],
                                SumaFixa = (double)reader["SumaFixa"],
                                ID_Utilizator = (long)reader["ID_Utilizator"],
                                DataModificare = (DateTime)reader["DataModificare"],
                                Status = Convert.ToInt32(reader["Status"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        public int PenalizariAdd(PenalizariInfo penalizare)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand("PenalizariAdd", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Procent", penalizare.Procent);
                    cmd.Parameters.AddWithValue("@SumaFixa", penalizare.SumaFixa);
                    cmd.Parameters.AddWithValue("@ID_Utilizator", penalizare.ID_Utilizator);
                    cmd.Parameters.AddWithValue("@DataModificare", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Status", penalizare.Status);

                    var idParam = new SqlParameter("@ID_Penalizari", SqlDbType.BigInt)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(idParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    return Convert.ToInt32(idParam.Value);
                }
            }
        }

        public void PenalizariUpdate(PenalizariInfo penalizare)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand("PenalizariUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID_Penalizari", penalizare.Id);
                    cmd.Parameters.AddWithValue("@Procent", penalizare.Procent);
                    cmd.Parameters.AddWithValue("@SumaFixa", penalizare.SumaFixa);
                    cmd.Parameters.AddWithValue("@ID_Utilizator", penalizare.ID_Utilizator);
                    cmd.Parameters.AddWithValue("@DataModificare", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Status", penalizare.Status);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
