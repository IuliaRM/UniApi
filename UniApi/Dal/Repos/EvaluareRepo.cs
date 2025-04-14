using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;

namespace UniApi.Dal.Repos
{
    public interface IEvaluareRepo
    {
        List<long> EvaluareGetIdsByUserIDAndRole(int userId, string role, long idAnUniv);
        List<string> EvaluareGetRoleByUserId(int userId);
        List<string> EvaluareGetRoleByUsername(string username);
        List<Dictionary<string, object>> EvaluareListByIDDetaliuPlanSemestru(long idDetaliuPlanSemestru);
    }

    public class EvaluareRepo : IEvaluareRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<long> EvaluareGetIdsByUserIDAndRole(int userId, string role, long idAnUniv)
        {
            var result = new List<long>();
            using (var reader = SqlHelper.ExecuteReader(_connectionString, "Evaluare_GetIdsByUserIDAndRole", userId, role, idAnUniv))
            {
                while (reader.Read())
                {
                    if (long.TryParse(reader[0].ToString(), out long id))
                    {
                        result.Add(id);
                    }
                }
            }
            return result;
        }

        public List<string> EvaluareGetRoleByUserId(int userId)
        {
            var result = new List<string>();
            using (var reader = SqlHelper.ExecuteReader(_connectionString, "Evaluare_GetRoleByUserId", userId))
            {
                while (reader.Read())
                {
                    result.Add(reader[0]?.ToString());
                }
            }
            return result;
        }

        public List<string> EvaluareGetRoleByUsername(string username)
        {
            var result = new List<string>();
            using (var reader = SqlHelper.ExecuteReader(_connectionString, "Evaluare_GetRoleByUsername", username))
            {
                while (reader.Read())
                {
                    result.Add(reader[0]?.ToString());
                }
            }
            return result;
        }

        public List<Dictionary<string, object>> EvaluareListByIDDetaliuPlanSemestru(long idDetaliuPlanSemestru)
        {
            var result = new List<Dictionary<string, object>>();
            using (var reader = SqlHelper.ExecuteReader(_connectionString, "Evaluare_ListByIDDetaliuPlanSemestru", idDetaliuPlanSemestru))
            {
                while (reader.Read())
                {
                    var row = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[reader.GetName(i)] = reader.IsDBNull(i) ? null : reader.GetValue(i);
                    }
                    result.Add(row);
                }
            }
            return result;
        }
    }
}
