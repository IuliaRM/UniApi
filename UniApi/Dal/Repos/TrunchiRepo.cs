using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class TrunchiRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TrunchiInfo TrunchiGet(long idTrunchi)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<TrunchiInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TrunchiGet", idTrunchi));
        }

        public List<TrunchiInfo> TrunchiListGet()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<TrunchiInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TrunchiList"));
        }

        public List<TrunchiInfo> TrunchiListDistinctMinGet()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<TrunchiInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TrunchiListDinstinctMin"));
        }

        public long TrunchiAdd(TrunchiInfo trunchiInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "TrunchiAdd", trunchiInfo.DenumireTrunchi, trunchiInfo.UserID_Coordonator);
            return Convert.ToInt64(id);
        }

        public void TrunchiUpdate(TrunchiInfo trunchiInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TrunchiUpdate", trunchiInfo.ID_Trunchi, trunchiInfo.DenumireTrunchi, trunchiInfo.UserID_Coordonator);
        }

        public void TrunchiDelete(long idTrunchi)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TrunchiDelete", idTrunchi);
        }
    }
}
